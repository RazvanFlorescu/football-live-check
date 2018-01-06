using System;
using FluentAssertions;

using FootballLiveCheck.Business.League.Commands;
using FootballLiveCheck.Business.League.CommandsHandlers;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Repositories;
using FootballLiveCheck.Tests.Shared;
using FootballLiveCheck.Tests.Shared.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FootballLiveCheck.Business.Tests.League.Commands
{
    [TestClass]
    public class CreateLeagueCommandHandlerTest : BaseCommandHandlerTest<CreateLeagueCommandHandler, CreateLeagueCommand, ILeagueRepository>
    {

        //  [TestMethod]
        //  public void Given_NumeMetoda_When_Conditie_Then_Should_Rezultat() { }

        [TestMethod]
        public void Given_Handle_When_PassedNullCommand_Then_Should_ThrowException()
        {
            Action act = () => SystemUnderTest.Handle(null);

            act.ShouldThrow<ArgumentNullException>();
        }

        [TestMethod]
        public void Given_Handle_When_PassedValidCommand_Then_Should_AddLeagueInRepository()
        {
            ExecuteCommand();
        }

        protected override CreateLeagueCommandHandler CreateSystemUnderTest()
        {
            return new CreateLeagueCommandHandler(MapperMock.Object, RepositoryMock.Object);
        }

        protected override CreateLeagueCommand CreateCommand()
        {
            var regionmodel = Region.Create("region", "www.test.com");
            var model = LeagueFactory.GetModel(20,"LSTN","LeagueFullTestName","https://www.flagTest.png",regionmodel );
            return new CreateLeagueCommand(model);
        }
    }
}