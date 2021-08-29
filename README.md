# Application overview
Develop an app that lets you tag a location of where you found a lost animal. 

With this kind of app you could potentially share the location with someone who has lost an animal so that they could find it. 

As an addition having the location of the nearest clinic (or any place) nearby could make it even easier to take them some place safe.

# The background
Three reasons why I have decided to start this pet project:
- I love pets.
- I find this application domain to be interesting for me.
- The learning purpose.

# Functional requirements
Very soon I will have a new project at work with a legacy codebase. In order to understand business domain faster
I do want to learn some technologies which are used there. That is why I will assume that current project has a client
which insist on the following technology stack:
- .NET Framework v4+, .NET MVC Solution
- .NET Framework Background Jobs
- NHibernate ORM
- MsSQL
- JavaScript (Angular and React if needed)

# Non-functional requirements (quality attributes)
I will take into account:
- Security
- Performance
- Scalability (as much as it is possible with monolith)
- Availability
- Monitoring
- Management (some admin UI page)
- Extensibility
- Maintainability
I will not take into account (at least from the start):
- Globalization

# Tests
The application should have:
- Unit tests.
- Acceptance/integration tests.
- UI tests (using JS or maybe some libraries).

# Design
I will try to figure out which way is better and faster for me right now to create such application:
- TDD approach
- Designing the architecture first (C4 diagrams)
Probably on the start I will combine both ways.

# CI/CD
CI should get the unit tests and integration tests results and verify that everything is green.
At the start I will have a development environment only.
After the project base increases I will consider some pre-prod and prod stages as well.

# Documentation
I expect to have:
- OpenAPI documentation for my endpoints.
- Design documentation in the github repo wiki page.
- Technical documentation in the repository.
- Sometimes the design docs for new features as google doc files or wiki pages.