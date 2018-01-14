using System;
using System.Collections.Generic;
using System.Text;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.Domain.Entities;

namespace FootballLiveCheck.Tests.Shared.Factories
{
    public class ArenaFactory
    {
        public static ArenaModel GetModel(Arena arena)
        {
            return new ArenaModel()
            {
                DbId = arena.DbId,
                Capacity = arena.Capacity,
                Name = arena.Name
            };
        }
    }
}
