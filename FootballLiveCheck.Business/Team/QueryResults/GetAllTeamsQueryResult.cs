using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Business.Team.QueryResults
{
    public class GetAllTeamsQueryResult : IQueryResult
    {
        public GetAllTeamsQueryResult(IReadOnlyCollection<TeamModel> teams)
        {
            EnsureArg.IsNotNull(teams);
            Teams = teams;
        }

        public IReadOnlyCollection<TeamModel> Teams { get; }
    }
}