﻿using System;

namespace FootballLiveCheck.Domain.Entities
{
    public class League : ApiEntity
    {
        private League()
        {
        }
        
        public string ShortName { get; private set; }

        public string Name { get; private set; }

        public string FlagURL { get; private set; }

        public int? RegionId { get; private set; }

        public virtual Region Region { get; private set; }

        public static League Create(int apiId, string shortName, string fullName, string flagURL, Region region)
        {
            return new League
            {
                DbId = apiId,
                ShortName = shortName,
                Name = fullName,
                FlagURL = flagURL,
                Region = region
                
            };
        }

        public static League Create(int apiId, string shortName, string fullName, string flagURL, int regionId)
        {
            return new League
            {
                DbId = apiId,
                ShortName = shortName,
                Name = fullName,
                FlagURL = flagURL,
                RegionId = regionId
               
            };
        }

        public void SetRegionId(int? regionId)
        {
            RegionId = regionId;
        }

    }
}