# Project Request
Project Request: an ASP.NET core MVC website project that implements Entity Framework Core for Axia Home Loans

This project make use of Model-View-Controller frame work from ASP.NET Core to generate webpage. 
This project also make use of Entity Core Framework to create Db Context and Db Sets used to communicate with a SQL server.
This project is designed with N-Tier Architechture in mind to divide responsibilities and separate dependencies with Inversion of Control and dependency injection.

This project is separated into Data, Model, Service, and Web layer, each layer serving a purpose and some depends on each others. The Database Context uses Dbsets to retrieve data from the database, which is then processed in the service request, which returns an Entity model that is mapped by the Controller to become a ViewModel with certain data attributes to display to the Views. 

Furthermore, I incorporated Azure AD service By modifying appsetting.json and Startup.cs in order to utilize OAuth2.0 to Authenticate users using microsoft's login service.

This project written is primarily in C# and C#html (Razor).

