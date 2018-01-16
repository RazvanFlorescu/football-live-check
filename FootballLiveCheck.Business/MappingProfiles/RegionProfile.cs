﻿using AutoMapper;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Business.Models.JSONObjects.JLeagues;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Business.MappingProfiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<Region, RegionModel>().ReverseMap();
            CreateMap<JRegion,Region>().ConvertUsing(Convert);
        }

        private Region Convert(JRegion model)
        {
            return Region.Create(model.DbId,model.Name, model.FlagUrl);
        }
    }
}