﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Project.Models;

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