////using System;
////using EnsureThat;
////using FootballLiveCheck.Business.Team.Models;
////using FootballLiveCheck.DbSynchronizer.JSONObjects.JTeams;
////using FootballLiveCheck.Domain.Entities;

////namespace FootballLiveCheck.DbSynchronizer.JSONMappings
////{
////    public class JTeamsMapping
////    {
////        //public static Team CreateEntity(JTeam jTeam)
////        //{
////        //    EnsureArg.IsNotNull(jTeam);
////        //    var entity = Team.Create(jTeam.Name, jTeam.ShortName, jTeam.Id, jTeam.ShirtUrl, jTeam.Arena);
////        //    return entity;
////        //}

////        //public static TeamModel UpdateModel(TeamModel team, JTeam jTeam)
////        //{
////        //    team.FullName = jTeam.Name;
////        //    team.ShortName = jTeam.ShortName;
////        //    team.ShirtUrl = jTeam.ShirtUrl;
////        //    //team.ArenaDbId = jTeam.DefaultHomeVenue.Dbid;
////        //    //team.ArenaName = jTeam.DefaultHomeVenue.Name;
////        //    //team.ArenaCapacity = jTeam.DefaultHomeVenue.Capacity;
////        //    return team;
////        //}
////    }
////}