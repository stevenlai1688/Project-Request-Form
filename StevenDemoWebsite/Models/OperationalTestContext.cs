using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StevenDemoWebsite.Models
{
    public partial class OperationalTestContext : DbContext
    {
        public OperationalTestContext()
        {
        }

        public OperationalTestContext(DbContextOptions<OperationalTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActiveBusinessReview> ActiveBusinessReviews { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<AssociatedBranch> AssociatedBranches { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BusinessReview> BusinessReviews { get; set; }
        public virtual DbSet<BusinessReviewFile> BusinessReviewFiles { get; set; }
        public virtual DbSet<BusinessReviewReport> BusinessReviewReports { get; set; }
        public virtual DbSet<ChecklistBranchChangeLog> ChecklistBranchChangeLogs { get; set; }
        public virtual DbSet<ChecklistBranchResponse> ChecklistBranchResponses { get; set; }
        public virtual DbSet<ChecklistCategory> ChecklistCategories { get; set; }
        public virtual DbSet<ChecklistChangeLog> ChecklistChangeLogs { get; set; }
        public virtual DbSet<ChecklistForm> ChecklistForms { get; set; }
        public virtual DbSet<ChecklistItem> ChecklistItems { get; set; }
        public virtual DbSet<ChecklistItemPermission> ChecklistItemPermissions { get; set; }
        public virtual DbSet<ChecklistResponse> ChecklistResponses { get; set; }
        public virtual DbSet<CombinedBranchView> CombinedBranchViews { get; set; }
        public virtual DbSet<CombinedView> CombinedViews { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CostCenter> CostCenters { get; set; }
        public virtual DbSet<DataChange> DataChanges { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeFile> EmployeeFiles { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<EncompassEmailDefinition> EncompassEmailDefinitions { get; set; }
        public virtual DbSet<EncompassEmailOptOut> EncompassEmailOptOuts { get; set; }
        public virtual DbSet<HireForm> HireForms { get; set; }
        public virtual DbSet<HireFormFile> HireFormFiles { get; set; }
        public virtual DbSet<HireFormWorkflow> HireFormWorkflows { get; set; }
        public virtual DbSet<HourlyRate> HourlyRates { get; set; }
        public virtual DbSet<IdeaInMotionComment> IdeaInMotionComments { get; set; }
        public virtual DbSet<IdeaInMotionFile> IdeaInMotionFiles { get; set; }
        public virtual DbSet<IdeasInMotion> IdeasInMotions { get; set; }
        public virtual DbSet<IndividualEmail> IndividualEmails { get; set; }
        public virtual DbSet<ItchangeMatrix> ItchangeMatrices { get; set; }
        public virtual DbSet<ItchangeMatrixFile> ItchangeMatricesFile { get; set; }
        public virtual DbSet<LoEmail> LoEmails { get; set; }
        public virtual DbSet<MilestoneEmailTemplate> MilestoneEmailTemplates { get; set; }
        public virtual DbSet<OnBoardingBranchComment> OnBoardingBranchComments { get; set; }
        public virtual DbSet<OpsLogsColumn> OpsLogsColumns { get; set; }
        public virtual DbSet<ProductionLevel> ProductionLevels { get; set; }
        public virtual DbSet<ProductionPlan> ProductionPlans { get; set; }
        public virtual DbSet<ProductionPlanDiscipline> ProductionPlanDisciplines { get; set; }
        public virtual DbSet<ProductionPlanProject> ProductionPlanProjects { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<RateDisclaimer> RateDisclaimers { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Response> Responses { get; set; }
        public virtual DbSet<ReverseProxyLookup> ReverseProxyLookups { get; set; }
        public virtual DbSet<Staging> Stagings { get; set; }
        public virtual DbSet<StateDisclaimer> StateDisclaimers { get; set; }
        public virtual DbSet<Statistic> Statistics { get; set; }
        public virtual DbSet<StevenDemoTable> StevenDemoTables { get; set; }
        public virtual DbSet<ThirdPartyEmail> ThirdPartyEmails { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<TicketApprover> TicketApprovers { get; set; }
        public virtual DbSet<TicketApproverStatus> TicketApproverStatuses { get; set; }
        public virtual DbSet<TicketFile> TicketFiles { get; set; }
        public virtual DbSet<TicketHistory> TicketHistories { get; set; }
        public virtual DbSet<TicketHistoryFile> TicketHistoryFiles { get; set; }
        public virtual DbSet<TicketReinbursement> TicketReinbursements { get; set; }
        public virtual DbSet<TicketReinbursementFile> TicketReinbursementFiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=axiawarehouse.database.windows.net;Database=Operational-Test;User Id=ExternalDev;password=7y67btOCaEIn9QUp;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ActiveBusinessReview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ActiveBusinessReview");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.EmployeeAcknowledgement).IsUnicode(false);

                entity.Property(e => e.EmployeeAcknowledgementDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeAveragePricingGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmployeeBuilder)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCostToCuresGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmployeeExistingRealtor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeLeadershipNotes).IsUnicode(false);

                entity.Property(e => e.EmployeeManagementAndDevelopmentNotes).IsUnicode(false);

                entity.Property(e => e.EmployeeNewPartnerMeeting)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeOpenHouseVisits)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeOtherMarketingEvents)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeePercentBondLoansGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmployeePurchasePercentageGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmployeePurchaseVolumeGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmployeeReferringPartner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeSelfDevelopmentNotes).IsUnicode(false);

                entity.Property(e => e.EmployeeTeamworkNotes).IsUnicode(false);

                entity.Property(e => e.EmployeeToolsResourcesTrainingNotes).IsUnicode(false);

                entity.Property(e => e.EmployeeTurnoverNotes).IsUnicode(false);

                entity.Property(e => e.EmployeeVolumeGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.EntityAveragePricingGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EntityCostToCuresGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EntityPercentBondLoansGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EntityPurchasePercentageGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EntityPurchaseVolumeGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EntityVolumeGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ManagerAcknowledgement).IsUnicode(false);

                entity.Property(e => e.ManagerAcknowledgementDate).HasColumnType("datetime");

                entity.Property(e => e.ManagerBuilder)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerBuilderOpportunities).IsUnicode(false);

                entity.Property(e => e.ManagerCorporateOpportunities).IsUnicode(false);

                entity.Property(e => e.ManagerExistingRealtor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerKeyTopics).IsUnicode(false);

                entity.Property(e => e.ManagerKeyWins).IsUnicode(false);

                entity.Property(e => e.ManagerLeadershipNotes).IsUnicode(false);

                entity.Property(e => e.ManagerLessThanThree).IsUnicode(false);

                entity.Property(e => e.ManagerManagementAndDevelopmentNotes).IsUnicode(false);

                entity.Property(e => e.ManagerNewPartnerMeeting)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerOpenHouseVisits)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerOtherMarketing).IsUnicode(false);

                entity.Property(e => e.ManagerOtherMarketingEvents)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerProducerRecognition).IsUnicode(false);

                entity.Property(e => e.ManagerRealtorOpportunities).IsUnicode(false);

                entity.Property(e => e.ManagerReferringPartner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerSelfDevelopmentNotes).IsUnicode(false);

                entity.Property(e => e.ManagerTeamworkNotes).IsUnicode(false);

                entity.Property(e => e.ManagerToolsResourcesTrainingNotes).IsUnicode(false);

                entity.Property(e => e.ManagerTurnoverNotes).IsUnicode(false);

                entity.Property(e => e.ReviewUserType)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TurnoverEmployeeNotes).IsUnicode(false);

                entity.Property(e => e.TurnoverManagerNotes).IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("Answer");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_Answer_Question");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.ToTable("Area");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.CostCenter)
                    .WithMany(p => p.Areas)
                    .HasForeignKey(d => d.CostCenterId)
                    .HasConstraintName("FK_Area_CostCenter");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Areas)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_Area_Employee");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Areas)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Area_Region");
            });

            modelBuilder.Entity<AssociatedBranch>(entity =>
            {
                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.AssociatedBranches)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssociatedBranches_Branch");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AssociatedBranches)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssociatedBranches_Employee");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("Branch");

                entity.HasIndex(e => e.Name, "IX_Branch_Name")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Disclaimer).IsUnicode(false);

                entity.Property(e => e.Disclosure).IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.LicensingInfo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NmlsId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SimpleName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(substring([Name],charindex(' ',[Name])+(1),len([Name])-(charindex(' ',[Name])-(1))))", false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_Branch_Area");

                entity.HasOne(d => d.CostCenter)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.CostCenterId)
                    .HasConstraintName("FK_Branch_CostCenter");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_Branch_Employee");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Branch_Region");

                entity.HasOne(d => d.ReportingBranch)
                    .WithMany(p => p.InverseReportingBranch)
                    .HasForeignKey(d => d.ReportingBranchId)
                    .HasConstraintName("FK_Branch_Branch");
            });

            modelBuilder.Entity<BusinessReview>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Version });

                entity.ToTable("BusinessReview");

                entity.HasIndex(e => e.Active, "IX_BusinessReview_Active");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.EmployeeAcknowledgement).IsUnicode(false);

                entity.Property(e => e.EmployeeAcknowledgementDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeAveragePricingGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmployeeBuilder).IsUnicode(false);

                entity.Property(e => e.EmployeeCostToCuresGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmployeeExistingRealtor).IsUnicode(false);

                entity.Property(e => e.EmployeeLeadershipNotes).IsUnicode(false);

                entity.Property(e => e.EmployeeManagementAndDevelopmentNotes).IsUnicode(false);

                entity.Property(e => e.EmployeeNewPartnerMeeting).IsUnicode(false);

                entity.Property(e => e.EmployeeOpenHouseVisits).IsUnicode(false);

                entity.Property(e => e.EmployeeOtherMarketingEvents).IsUnicode(false);

                entity.Property(e => e.EmployeePercentBondLoansGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmployeePurchasePercentageGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmployeePurchaseVolumeGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmployeeReferringPartner).IsUnicode(false);

                entity.Property(e => e.EmployeeSelfDevelopmentNotes).IsUnicode(false);

                entity.Property(e => e.EmployeeTeamworkNotes).IsUnicode(false);

                entity.Property(e => e.EmployeeToolsResourcesTrainingNotes).IsUnicode(false);

                entity.Property(e => e.EmployeeTurnoverNotes).IsUnicode(false);

                entity.Property(e => e.EmployeeVolumeGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.EntityAveragePricingGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EntityCostToCuresGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EntityPercentBondLoansGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EntityPurchasePercentageGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EntityPurchaseVolumeGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EntityVolumeGoal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastLogDate).HasColumnType("datetime");

                entity.Property(e => e.ManagerAcknowledgement).IsUnicode(false);

                entity.Property(e => e.ManagerAcknowledgementDate).HasColumnType("datetime");

                entity.Property(e => e.ManagerBuilder).IsUnicode(false);

                entity.Property(e => e.ManagerBuilderOpportunities).IsUnicode(false);

                entity.Property(e => e.ManagerCorporateOpportunities).IsUnicode(false);

                entity.Property(e => e.ManagerExistingRealtor).IsUnicode(false);

                entity.Property(e => e.ManagerKeyTopics).IsUnicode(false);

                entity.Property(e => e.ManagerKeyWins).IsUnicode(false);

                entity.Property(e => e.ManagerLeadershipNotes).IsUnicode(false);

                entity.Property(e => e.ManagerLessThanThree).IsUnicode(false);

                entity.Property(e => e.ManagerManagementAndDevelopmentNotes).IsUnicode(false);

                entity.Property(e => e.ManagerNewPartnerMeeting).IsUnicode(false);

                entity.Property(e => e.ManagerOpenHouseVisits).IsUnicode(false);

                entity.Property(e => e.ManagerOtherMarketing).IsUnicode(false);

                entity.Property(e => e.ManagerOtherMarketingEvents).IsUnicode(false);

                entity.Property(e => e.ManagerProducerRecognition).IsUnicode(false);

                entity.Property(e => e.ManagerRealtorOpportunities).IsUnicode(false);

                entity.Property(e => e.ManagerReferringPartner).IsUnicode(false);

                entity.Property(e => e.ManagerSelfDevelopmentNotes).IsUnicode(false);

                entity.Property(e => e.ManagerTeamworkNotes).IsUnicode(false);

                entity.Property(e => e.ManagerToolsResourcesTrainingNotes).IsUnicode(false);

                entity.Property(e => e.ManagerTurnoverNotes).IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReviewUserType)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TurnoverEmployeeNotes).IsUnicode(false);

                entity.Property(e => e.TurnoverManagerNotes).IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BusinessReviews)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_BusinessReview_Branch");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.BusinessReviews)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_BusinessReview_Employee");
            });

            modelBuilder.Entity<BusinessReviewFile>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.BusinessReview)
                    .WithMany(p => p.BusinessReviewFiles)
                    .HasForeignKey(d => new { d.BusinessReviewId, d.BusinessReviewVersion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessReviewFiles_BusinessReview");
            });

            modelBuilder.Entity<BusinessReviewReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BusinessReviewReport");

                entity.Property(e => e.CurrentStatus)
                    .IsRequired()
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.DateGenerated)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateRange)
                    .HasMaxLength(23)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratedBy)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratedFor)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChecklistBranchChangeLog>(entity =>
            {
                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.ChecklistBranchChangeLogs)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChecklistBranchChangeLogs_Branch");

                entity.HasOne(d => d.ChecklistItem)
                    .WithMany(p => p.ChecklistBranchChangeLogs)
                    .HasForeignKey(d => d.ChecklistItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChecklistBranchChangeLogs_ChecklistItem");

                entity.HasOne(d => d.CurrentUser)
                    .WithMany(p => p.ChecklistBranchChangeLogs)
                    .HasForeignKey(d => d.CurrentUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChecklistBranchChangeLogs_Employee");
            });

            modelBuilder.Entity<ChecklistBranchResponse>(entity =>
            {
                entity.ToTable("ChecklistBranchResponse");

                entity.Property(e => e.CheckedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.ChecklistBranchResponses)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChecklistBranchResponse_Branch");

                entity.HasOne(d => d.CheckListItem)
                    .WithMany(p => p.ChecklistBranchResponses)
                    .HasForeignKey(d => d.CheckListItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChecklistBranchResponse_ChecklistItem");

                entity.HasOne(d => d.CheckedByUser)
                    .WithMany(p => p.ChecklistBranchResponses)
                    .HasForeignKey(d => d.CheckedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChecklistBranchResponse_Employee");
            });

            modelBuilder.Entity<ChecklistCategory>(entity =>
            {
                entity.ToTable("ChecklistCategory");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormId).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.ChecklistCategories)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChecklistCategory_ChecklistForm");
            });

            modelBuilder.Entity<ChecklistChangeLog>(entity =>
            {
                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.ChecklistItem)
                    .WithMany(p => p.ChecklistChangeLogs)
                    .HasForeignKey(d => d.ChecklistItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChecklistChangeLogs_ChecklistItem");

                entity.HasOne(d => d.CurrentUser)
                    .WithMany(p => p.ChecklistChangeLogCurrentUsers)
                    .HasForeignKey(d => d.CurrentUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChecklistChangeLogs_Employee1");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ChecklistChangeLogEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChecklistChangeLogs_Employee");
            });

            modelBuilder.Entity<ChecklistForm>(entity =>
            {
                entity.ToTable("ChecklistForm");

                entity.Property(e => e.Form)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChecklistItem>(entity =>
            {
                entity.ToTable("ChecklistItem");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ChecklistItems)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChecklistItem_ChecklistCategory");
            });

            modelBuilder.Entity<ChecklistItemPermission>(entity =>
            {
                entity.ToTable("ChecklistItemPermission");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ChecklistItem)
                    .WithMany(p => p.ChecklistItemPermissions)
                    .HasForeignKey(d => d.ChecklistItemId)
                    .HasConstraintName("FK_ChecklistItemPermission_ChecklistItem");

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.ChecklistItemPermissions)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .HasConstraintName("FK_ChecklistItemPermission_EmployeeType");
            });

            modelBuilder.Entity<ChecklistResponse>(entity =>
            {
                entity.ToTable("ChecklistResponse");

                entity.Property(e => e.CheckedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.CheckListItem)
                    .WithMany(p => p.ChecklistResponses)
                    .HasForeignKey(d => d.CheckListItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChecklistResponse_ChecklistItem");

                entity.HasOne(d => d.CheckedByUser)
                    .WithMany(p => p.ChecklistResponseCheckedByUsers)
                    .HasForeignKey(d => d.CheckedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChecklistResponse_Employee");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ChecklistResponseEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChecklistResponse_Employee1");
            });

            modelBuilder.Entity<CombinedBranchView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CombinedBranchView");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaManagerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AreaManagerName)
                    .HasMaxLength(102)
                    .IsUnicode(false);

                entity.Property(e => e.AreaManagerUserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BranchManagerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchManagerUserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionManagerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionManagerUserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegionManagerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegionManagerUserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CombinedView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CombinedView");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdpId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AkaFirstLast)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.AkaFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AkaLastFirst)
                    .HasMaxLength(102)
                    .IsUnicode(false);

                entity.Property(e => e.AkaLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaManagerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AreaManagerName)
                    .HasMaxLength(102)
                    .IsUnicode(false);

                entity.Property(e => e.AreaManagerUserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AscentEnrollmentDate).HasColumnType("date");

                entity.Property(e => e.BranchManagerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchManagerUserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CFirstLast)
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("C_FirstLast");

                entity.Property(e => e.CLastFirst)
                    .HasMaxLength(102)
                    .IsUnicode(false)
                    .HasColumnName("C_LastFirst");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenter)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cplp).HasColumnName("CPLP");

                entity.Property(e => e.Division)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionManagerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionManagerUserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeUserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerName)
                    .HasMaxLength(102)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCreditCap).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NmlsId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Qplp).HasColumnName("QPLP");

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegionManagerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegionManagerUserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportingBranch)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ReportingBranchManagerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportingBranchManagerUserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesManagerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesManagerName)
                    .HasMaxLength(102)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseAkaname).HasColumnName("UseAKAName");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.View)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CommentCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Comments_Employee");

                entity.HasOne(d => d.CreatedForNavigation)
                    .WithMany(p => p.CommentCreatedForNavigations)
                    .HasForeignKey(d => d.CreatedFor)
                    .HasConstraintName("FK_Comments_Employee1");
            });

            modelBuilder.Entity<CostCenter>(entity =>
            {
                entity.ToTable("CostCenter");

                entity.HasIndex(e => e.Code, "IX_CostCenter")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Primary).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportsTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataChange>(entity =>
            {
                entity.ToTable("DataChange");

                entity.Property(e => e.BranchFullAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Licence)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessorEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessorPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.ToTable("Division");

                entity.HasIndex(e => e.Name, "IX_Division_Name")
                    .IsUnique();

                entity.Property(e => e.Disclaimer).IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CostCenter)
                    .WithMany(p => p.Divisions)
                    .HasForeignKey(d => d.CostCenterId)
                    .HasConstraintName("FK_Division_CostCenter");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Divisions)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_Division_Employee");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => e.AdpId, "IX_Employee_AdpId")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "IX_Employee_Email");

                entity.HasIndex(e => e.Id, "IX_Employee_Shortcut")
                    .IsUnique();

                entity.Property(e => e.AdpId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AkaFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AkaLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AkaName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationUrl)
                    .HasMaxLength(155)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationUrlShortcut)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AscentEnrollmentDate).HasColumnType("date");

                entity.Property(e => e.Bio).IsUnicode(false);

                entity.Property(e => e.CFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_FirstName")
                    .HasComputedColumnSql("(case when [AkaFirstName]='' OR [AkaFirstName] IS NULL then [FirstName] else [AkaFirstName] end)", false);

                entity.Property(e => e.CLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_LastName")
                    .HasComputedColumnSql("(case when [AkaLastName]='' OR [AkaLastName] IS NULL then [LastName] else [AkaLastName] end)", false);

                entity.Property(e => e.Cell)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cplp).HasColumnName("CPLP");

                entity.Property(e => e.Disclaimer).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EncompassLogin)
                    .HasMaxLength(155)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Facebook)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLast)
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(([FirstName]+' ')+[LastName])", false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl).IsUnicode(false);

                entity.Property(e => e.ImpersonateUser)
                    .HasMaxLength(155)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastFirst)
                    .HasMaxLength(102)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(([LastName]+', ')+[FirstName])", false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicensingInfo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedIn)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoSubDomain)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LoWebsite)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCreditCap).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MobileUrl).IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NmlsId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qplp).HasColumnName("QPLP");

                entity.Property(e => e.RehireDate).HasColumnType("date");

                entity.Property(e => e.SignatureEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureOverrideDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Twitter)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UseAkaname).HasColumnName("UseAKAName");

                entity.Property(e => e.Zillow)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_Employee_Area");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.EmployeeBranches)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_Employee_Branch");

                entity.HasOne(d => d.CostCenter)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.CostCenterId)
                    .HasConstraintName("FK_Employee_CostCenter");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_Employee_Manager");

                entity.HasOne(d => d.ProductionLevel)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ProductionLevelId)
                    .HasConstraintName("FK_Employee_ProductionLevel");

                entity.HasOne(d => d.ReportingBranch)
                    .WithMany(p => p.EmployeeReportingBranches)
                    .HasForeignKey(d => d.ReportingBranchId)
                    .HasConstraintName("FK_Employee_ReportingBranch");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("FK_Employee_EmployeeType");
            });

            modelBuilder.Entity<EmployeeFile>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeFiles)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeFiles_Employee");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("EmployeeType");

                entity.HasIndex(e => e.Name, "UQ__Employee__737584F6CEEBB705")
                    .IsUnique();

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EncompassEmailDefinition>(entity =>
            {
                entity.Property(e => e.BccAddresses).IsUnicode(false);

                entity.Property(e => e.CcAddresses).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.FromAddresses)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Json).IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QueryCriteria).IsUnicode(false);

                entity.Property(e => e.SentFieldId)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Template).IsUnicode(false);

                entity.Property(e => e.ToAddresses).IsUnicode(false);
            });

            modelBuilder.Entity<EncompassEmailOptOut>(entity =>
            {
                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EncompassEmailOptOuts)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EncompassEmailOptOuts_Employee");

                entity.HasOne(d => d.EncompassEmailDefinition)
                    .WithMany(p => p.EncompassEmailOptOuts)
                    .HasForeignKey(d => d.EncompassEmailDefinitionId)
                    .HasConstraintName("FK_EncompassEmailOptOuts_EncompassEmailDefinitions");
            });

            modelBuilder.Entity<HireForm>(entity =>
            {
                entity.ToTable("HireForm");

                entity.Property(e => e.BusinessCard)
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.Database)
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.EmailGroups)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.FirstPaycheck)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullLegalName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KeyboardAndMouse)
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.Manager)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerContactInfo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameTag)
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.NmlsId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeConfiguration)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OtherEmailGroup)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OtherTitlePosition)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PersonalEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonalMobileInMarketing)
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.PersonalMobileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneAndExtension)
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.PhotoOnCard)
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.PhysicalDeskPhone)
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.PreferrerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreferrerTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousUsersFax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousUsersPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReissuingEquipment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SharedDrivesFolders)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCorporateBranch)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToDivision1)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToDivision2)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToOtherBranch)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatesLicencedId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Workstation)
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.HireForms)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HireForm_Branch1");

                entity.HasOne(d => d.CostCenter)
                    .WithMany(p => p.HireForms)
                    .HasForeignKey(d => d.CostCenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HireForm_CostCenter1");

                entity.HasOne(d => d.TitlePosition)
                    .WithMany(p => p.HireForms)
                    .HasForeignKey(d => d.TitlePositionId)
                    .HasConstraintName("FK_HireForm_EmployeeType1");
            });

            modelBuilder.Entity<HireFormFile>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.HireFormFiles)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeFiles_HireFormWorkflow");
            });

            modelBuilder.Entity<HireFormWorkflow>(entity =>
            {
                entity.ToTable("HireFormWorkflow");

                entity.Property(e => e.AdditionalTerms)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AnticipatedStartDate).HasColumnType("date");

                entity.Property(e => e.BaseBps)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bps)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Duration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveLocation)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.IntroductoryBps)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NeedExplanation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentLocation)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalLocation)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PositionManager)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SigningBonus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedByUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CostCenter)
                    .WithMany(p => p.HireFormWorkflows)
                    .HasForeignKey(d => d.CostCenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HireFormWorkflow_CostCenter");

                entity.HasOne(d => d.LocationNavigation)
                    .WithMany(p => p.HireFormWorkflows)
                    .HasForeignKey(d => d.Location)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HireFormWorkflow_Branch");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.HireFormWorkflows)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HireFormWorkflow_EmployeeType");
            });

            modelBuilder.Entity<HourlyRate>(entity =>
            {
                entity.ToTable("HourlyRate");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.HourlyRates)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HourlyRate_EmployeeType");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.HourlyRates)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_HourlyRate_Employee");
            });

            modelBuilder.Entity<IdeaInMotionComment>(entity =>
            {
                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.IdeaInMotionComments)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdeaInMotionComments_Employee");

                entity.HasOne(d => d.IdeaInMotion)
                    .WithMany(p => p.IdeaInMotionComments)
                    .HasForeignKey(d => d.IdeaInMotionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdeaInMotionComments_IdeasInMotion");
            });

            modelBuilder.Entity<IdeaInMotionFile>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.IdeaInMotion)
                    .WithMany(p => p.IdeaInMotionFiles)
                    .HasForeignKey(d => d.IdeaInMotionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdeaInMotionFiles_IdeasInMotion");
            });

            modelBuilder.Entity<IdeasInMotion>(entity =>
            {
                entity.ToTable("IdeasInMotion");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Departments).IsUnicode(false);

                entity.Property(e => e.FinalResponse).IsUnicode(false);

                entity.Property(e => e.HardCost)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idea)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.IdeaPurpose)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iimstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IIMStatus");

                entity.Property(e => e.InitialResponse).IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ResourcesNeccesary).IsUnicode(false);

                entity.Property(e => e.Result).IsUnicode(false);

                entity.Property(e => e.Summary)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TimeToComplete)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdeaOwner)
                    .WithMany(p => p.IdeasInMotions)
                    .HasForeignKey(d => d.IdeaOwnerId)
                    .HasConstraintName("FK_IdeasInMotion_Employee");

                entity.HasOne(d => d.PrimaryDepartment)
                    .WithMany(p => p.IdeasInMotions)
                    .HasForeignKey(d => d.PrimaryDepartmentId)
                    .HasConstraintName("FK_IdeasInMotion_CostCenter");
            });

            modelBuilder.Entity<IndividualEmail>(entity =>
            {
                entity.ToTable("IndividualEmail");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ItchangeMatrix>(entity =>
            {
                entity.ToTable("ITChangeMatrix");

                entity.Property(e => e.ChangeActivity)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeNeededBy).HasColumnType("datetime");

                entity.Property(e => e.CommunicationRequired)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Discipline)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentedProcedure)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Itcabrequired)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITCABRequired");

                entity.Property(e => e.LogRequired)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OutageDuration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonForChange)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RollbackPlan)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ApprovedByNavigation)
                    .WithMany(p => p.ItchangeMatrices)
                    .HasForeignKey(d => d.ApprovedBy)
                    .HasConstraintName("FK_ITChangeMatrix_Employee");
            });

            modelBuilder.Entity<ItchangeMatrixFile>(entity =>
            {
                entity.ToTable("ITChangeMatrixFile");

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ItchangeMatrixId).HasColumnName("ITChangeMatrixId");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.ItchangeMatrix)
                    .WithMany(p => p.ItchangeMatricesFile)
                    .HasForeignKey(d => d.ItchangeMatrixId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ITChangeMatrixFile_ITChangeMatrix");
            });

            modelBuilder.Entity<LoEmail>(entity =>
            {
                entity.ToTable("LoEmail");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MilestoneEmailTemplate>(entity =>
            {
                entity.ToTable("MilestoneEmailTemplate");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Template)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OnBoardingBranchComment>(entity =>
            {
                entity.ToTable("OnBoardingBranchComment");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.View)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.OnBoardingBranchComments)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_OnBoardingBranchComment_Employee");

                entity.HasOne(d => d.CreatedForNavigation)
                    .WithMany(p => p.OnBoardingBranchComments)
                    .HasForeignKey(d => d.CreatedFor)
                    .HasConstraintName("FK_OnBoardingBranchComment_Branch");
            });

            modelBuilder.Entity<OpsLogsColumn>(entity =>
            {
                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Report)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductionLevel>(entity =>
            {
                entity.ToTable("ProductionLevel");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductionLevel1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProductionLevel");
            });

            modelBuilder.Entity<ProductionPlan>(entity =>
            {
                entity.ToTable("ProductionPlan");

                entity.Property(e => e.AprilVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AugustVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DecemberVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FebruaryVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.JanuaryVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.JulyVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.JuneVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MarchVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MayVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NovemberVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OctoberVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductionLevelFirstQuarter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionLevelFourthQuarter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionLevelSecondQuarter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionLevelThirdQuarter)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SeptemberVolume).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateSentOn).HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ProductionPlans)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductionPlan_Employee");
            });

            modelBuilder.Entity<ProductionPlanDiscipline>(entity =>
            {
                entity.ToTable("ProductionPlanDiscipline");

                entity.Property(e => e.Discipline)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductionPlan)
                    .WithMany(p => p.ProductionPlanDisciplines)
                    .HasForeignKey(d => d.ProductionPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductionPlanDiscipline_ProductionPlan");
            });

            modelBuilder.Entity<ProductionPlanProject>(entity =>
            {
                entity.ToTable("ProductionPlanProject");

                entity.Property(e => e.CompletedBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductionPlan)
                    .WithMany(p => p.ProductionPlanProjects)
                    .HasForeignKey(d => d.ProductionPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductionPlanProject_ProductionPlan");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ResponseType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RateDisclaimer>(entity =>
            {
                entity.ToTable("RateDisclaimer");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Disclaimer)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Rate)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.RateDisclaimers)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_RateDisclaimer_Employee");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Region");

                entity.HasIndex(e => e.Name, "IX_Region_Name")
                    .IsUnique();

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CostCenter)
                    .WithMany(p => p.Regions)
                    .HasForeignKey(d => d.CostCenterId)
                    .HasConstraintName("FK_Region_CostCenter");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Regions)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_Region_Division");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Regions)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_Region_Employee");
            });

            modelBuilder.Entity<Response>(entity =>
            {
                entity.ToTable("Response");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ResponseDate).HasColumnType("date");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.Responses)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Response_Answer");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Responses)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Response_Question");
            });

            modelBuilder.Entity<ReverseProxyLookup>(entity =>
            {
                entity.ToTable("ReverseProxyLookup");

                entity.Property(e => e.StartsWithSegments)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TargetUri)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Staging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Staging");

                entity.Property(e => e.Id)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e._1)
                    .IsUnicode(false)
                    .HasColumnName("1");

                entity.Property(e => e._10)
                    .IsUnicode(false)
                    .HasColumnName("10");

                entity.Property(e => e._11)
                    .IsUnicode(false)
                    .HasColumnName("11");

                entity.Property(e => e._12)
                    .IsUnicode(false)
                    .HasColumnName("12");

                entity.Property(e => e._13)
                    .IsUnicode(false)
                    .HasColumnName("13");

                entity.Property(e => e._14)
                    .IsUnicode(false)
                    .HasColumnName("14");

                entity.Property(e => e._15)
                    .IsUnicode(false)
                    .HasColumnName("15");

                entity.Property(e => e._2)
                    .IsUnicode(false)
                    .HasColumnName("2");

                entity.Property(e => e._3)
                    .IsUnicode(false)
                    .HasColumnName("3");

                entity.Property(e => e._4)
                    .IsUnicode(false)
                    .HasColumnName("4");

                entity.Property(e => e._5)
                    .IsUnicode(false)
                    .HasColumnName("5");

                entity.Property(e => e._6)
                    .IsUnicode(false)
                    .HasColumnName("6");

                entity.Property(e => e._7)
                    .IsUnicode(false)
                    .HasColumnName("7");

                entity.Property(e => e._8)
                    .IsUnicode(false)
                    .HasColumnName("8");

                entity.Property(e => e._9)
                    .IsUnicode(false)
                    .HasColumnName("9");
            });

            modelBuilder.Entity<StateDisclaimer>(entity =>
            {
                entity.ToTable("StateDisclaimer");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Disclaimer)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.StateDisclaimers)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_StateDisclaimer_Employee");
            });

            modelBuilder.Entity<Statistic>(entity =>
            {
                entity.Property(e => e.EmployeeApplications).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeApplicationsYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeAverageAppToFunded).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeAverageAppToFundedYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeAverageAppToProcess).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeAverageAppToProcessYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeAveragePricing).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeAveragePricingYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeBondLoans).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeBondLoansYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeCostToCure).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeCostToCureYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeExtensionRequests).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeExtensionRequestsYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeLeads).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeLeadsYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeOneTouch).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeOneTouchYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeePurchasePercentage).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeePurchasePercentageYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeePurchaseVolume).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeePurchaseVolumeYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeUnits).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeUnitsYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeVolume).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EmployeeVolumeYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityApplications).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityApplicationsYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityAverageAppToFunded).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityAverageAppToFundedYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityAverageAppToProcess).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityAverageAppToProcessYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityAveragePricing).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityAveragePricingYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityBondLoans).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityBondLoansYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityCostToCure).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityCostToCureYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityExtensionRequests).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityExtensionRequestsYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityLeads).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityLeadsYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityOneTouch).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityOneTouchYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityPurchasePercentage).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityPurchasePercentageYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityPurchaseVolume).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityPurchaseVolumeYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityUnits).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityUnitsYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityVolume).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.EntityVolumeYtd).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<StevenDemoTable>(entity =>
            {
                entity.ToTable("StevenDemoTable");

                entity.Property(e => e.RequestorName).IsRequired();
            });

            modelBuilder.Entity<ThirdPartyEmail>(entity =>
            {
                entity.ToTable("ThirdPartyEmail");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeToSpecified)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChargedTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpired).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Vendor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TicketEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ticket_Employee2");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.TicketModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Ticket_Employee1");

                entity.HasOne(d => d.SubmittingFor)
                    .WithMany(p => p.TicketSubmittingFors)
                    .HasForeignKey(d => d.SubmittingForId)
                    .HasConstraintName("FK_Ticket_Employee");
            });

            modelBuilder.Entity<TicketApprover>(entity =>
            {
                entity.ToTable("TicketApprover");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.TicketApprovers)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketApprover_EmployeeType");
            });

            modelBuilder.Entity<TicketApproverStatus>(entity =>
            {
                entity.ToTable("TicketApproverStatus");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TicketApprover)
                    .WithMany(p => p.TicketApproverStatuses)
                    .HasForeignKey(d => d.TicketApproverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketStatus_TicketApprover");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketApproverStatuses)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketApproverStatus_Ticket");
            });

            modelBuilder.Entity<TicketFile>(entity =>
            {
                entity.ToTable("TicketFile");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketFiles)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketFile_Ticket");
            });

            modelBuilder.Entity<TicketHistory>(entity =>
            {
                entity.ToTable("TicketHistory");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TicketHistories)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketHistory_Employee");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketHistories)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketHistory_Ticket");
            });

            modelBuilder.Entity<TicketHistoryFile>(entity =>
            {
                entity.ToTable("TicketHistoryFile");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.TicketHistory)
                    .WithMany(p => p.TicketHistoryFiles)
                    .HasForeignKey(d => d.TicketHistoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketHistoryFile_TicketHistory");
            });

            modelBuilder.Entity<TicketReinbursement>(entity =>
            {
                entity.ToTable("TicketReinbursement");

                entity.Property(e => e.ChargeFrequency)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDeliveryMethod)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDeliveryMethodSpecified)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RequestType)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketReinbursements)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketReinbursement_Ticket");
            });

            modelBuilder.Entity<TicketReinbursementFile>(entity =>
            {
                entity.ToTable("TicketReinbursementFile");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.TicketReinbursement)
                    .WithMany(p => p.TicketReinbursementFiles)
                    .HasForeignKey(d => d.TicketReinbursementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketReinbursementFile_TicketReinbursement");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
