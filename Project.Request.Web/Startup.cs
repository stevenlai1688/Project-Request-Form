using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project.Request.Data;
using Project.Request.Data.Factory;
using Project.Request.Models;
using Project.Request.Models.Settings;
using Project.Request.Services.Helpers;
using Project.Request.Services.Interfaces;
using Project.Request.Services.Services;
using Serilog;

namespace Project.Request.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // Reading .Net OAuth Authentication
        // -> 3rd party authentication 
        // authentication -> we know who you are
        // authorization -> does user have permission
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<ConnectionStrings>(Configuration.GetSection("ConnectionStrings"));
            services.Configure<SmtpSettings>(Configuration.GetSection("Smtp"));
            services.Configure<MailAddressSettings>(Configuration.GetSection("MailAddressSettings"));

            services.AddDbContext<StevenDemoWebsiteContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("OperationalConnection")),
                ServiceLifetime.Transient);

            // on start up, everytime we request service, it will addtransient, help with dependency inject
            services.AddTransient<IProjectRequestService, ProjectRequestService>();
            services.AddTransient<ICostCenterService, CostCenterService>();
            services.AddTransient<IDbContextFactory, DbContextFactory>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<HtmlTemplate, HtmlTemplate>();
            // add Azure AD to services
            services.AddAuthentication(AzureADDefaults.AuthenticationScheme)
                .AddAzureAD(options => Configuration.Bind("AzureAd", options));
            // add authorization to controller
            services.AddControllersWithViews(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            }).AddRazorRuntimeCompilation();

            services.AddRazorPages();
            services.AddAutoMapper(typeof(Startup));
            
            services.AddLogging(config => config.AddSerilog());

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            // authenticaiton
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSerilogRequestLogging();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}