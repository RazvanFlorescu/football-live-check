using System;
using FluentAssertions;
using FootballLiveCheck.Business.Team.CommandHandlers;
using FootballLiveCheck.Business.Team.Commands;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;
using FootballLiveCheck.Tests.Shared;
using FootballLiveCheck.Tests.Shared.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballLiveCheck.Business.Tests.Team.Commands
{
    [TestClass]
    public class CreateTeamCommandHandlerTest : BaseCommandHandlerTest<CreateTeamCommandHandler, CreateTeamCommand, ITeamRepository>
    {
        private readonly Guid leagueId = new Guid("555F951D-C321-4ED2-8ADA-F0DEAB53C557");

      //  [TestMethod]
      //  public void Given_NumeMetoda_When_Conditie_Then_Should_Rezultat() { }

        [TestMethod]
        public void Given_Handle_When_PassedNullCommand_Then_Should_ThrowException()
        {
            Action act = () => SystemUnderTest.Handle(null);

            act.ShouldThrow<ArgumentNullException>();
        }

        [TestMethod]
        public void Given_Handle_When_PassedValidCommand_Then_Should_AddTeamInRepository()
        {
            ExecuteCommand();
        }

        protected override CreateTeamCommandHandler CreateSystemUnderTest()
        {
            return new CreateTeamCommandHandler(MapperMock.Object, RepositoryMock.Object);
        }

        protected override CreateTeamCommand CreateCommand()
        {
            Arena arena = Arena.Create(1, "arena", "121");
            var model = TeamFactory.GetModel("TeamTestName","ShortName",
                  20, "url",arena);
            return new CreateTeamCommand(model);
        }
    }
}