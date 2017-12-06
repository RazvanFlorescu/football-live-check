# FootballLiveCheck 
The project's main purpose is to privide an web app capable of providing real time football events.
The user will:
- be notified real time about his favorite team's games
- be able to check statistics about previous games
- be able to check leaderboards
- be able to chat real time with the other users.

An extra feature would be represented by a service capable of estimating game outcomes depending on match history, teams' net worth, etc.

## Structure -> N-Tiered : 
### Core   -> 3 projects : 
* Domain   	-> Entities, Interfaces, Enums
* Bussiness	-> Commands, Queries, Models(DTO's), Services etc
* CQRS		-> CQRS interfaces
### Infrastructures	(3rd parties implementations)	-> 2 projects :
* Infrastructure
* Data	        -> repositories' implementations
### Presentation    	-> 2 projects   
* Service	->  The Api
* WEB	-> Front-end Host ( Angular )

## Naming Conventions
### Repositories
  * I{Entity}Repository
  * {Entity}Repository

### Business:
* Commands:
	* {Action}{Entity}Command
	* {Action}{Entity}CommandHandler
* Queries:
	* {Action}{Entity}Query
	* {Action}{Entity}QueryHandler
* Events:
	* {Action}{Entity}Event
	* {Action}{Entity}EventHandler
