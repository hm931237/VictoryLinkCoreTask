using AutoMapper;
using SqlProvider.Entities;
using SqlProvider.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<IncomeRequestViewModel, Request>();
        }
    }
}
