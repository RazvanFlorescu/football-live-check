using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.Business.Team.QueryHandlers;
using FootballLiveCheck.Business.Team.QueryResults;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;
using FootballLiveCheck.Tests.Shared;
using FootballLiveCheck.Tests.Shared.Extensions;
using FootballLiveCheck.Tests.Shared.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballLiveCheck.Business.Tests.Team.Queries
{
    [TestClass]
    public class GetTeamByIdQueryHandlerTest : BaseQueryHandlerTest<GetTeamByIdQueryHandler, GetTeamByIdQuery,
        GetTeamByIdQueryResult, ITeamRepository>
    {
        private readonly int id = 12;
        private readonly Guid leagueId = new Guid("555F951D-C321-4ED2-8ADA-F0DEAB53C557");

        [TestMethod]
        public void Given_Retrieve_When_PassedNullQuery_Then_Should_ThrowException()
        {
            Action act = () => SystemUnderTest.Retrieve(null);

            act.ShouldThrow<ArgumentNullException>();
        }

        [TestMethod]
        public void Given_Retrieve_When_PassedValidQuery_Then_Should_ReturnTeamById()
        {
            Arena arena = Arena.Create(1, "arena", "121");
            var team = TeamFactory.GetEntity("TeamTestName", "ShortName",
                20, "url", arena);
            RepositoryMock.Setup(r => r.GetById(id)).Returns(team);
            var model = TeamFactory.GetModel(team);
            MapperMock.Setup(m => m.Map<TeamModel>(team)).Returns(model);

            var result = ExecuteQuery();

            result.Should().NotBeNull();
            result.Team.Should().NotBeNull();
        }

        protected override GetTeamByIdQueryHandler CreateSystemUnderTest()
        {
            return new GetTeamByIdQueryHandler(MapperMock.Object, RepositoryMock.Object);
        }

        protected override GetTeamByIdQuery CreateQuery()
        {
            return new GetTeamByIdQuery(id);
        }
    }
}