using AutoMapper;
using Project.Request.Models.DataModels;
using Project.Request.Web.Models;

namespace Project.Request.Web
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            // create maps between the viewmodel and the entity models
            CreateMap<ProjectRequestViewModel, ProjectRequest>();
            CreateMap<ProjectRequest, ProjectRequestViewModel>();

            CreateMap<PriorityLevelViewModel, PriorityLevel>();
            CreateMap<PriorityLevel, PriorityLevelViewModel>();

            CreateMap<CostCenter, CostCenterViewModel>();
            CreateMap<CostCenterViewModel, CostCenter>();
        }
    }
}