# StevenDemoWebsite
ASP.NET core MVC website using Entity Framework Core for Axia Home Loans Project Request

This project make use of Model-View-Controller frame work from ASP.NET Core to generate webpage. 
This project also make use of Entity Core Framework to create Db Context and Db Sets used to communicate with a SQL server.
This project is designed with N-Tier Architechture in mind to divide responsibilities and separate dependencies with Inversion of Control.

This project is separated into Data, Model, Service, and Web layer, each serving a purpose. The database context models off of Entity Model and uses Dbsets to retrieve data from the database, which is then requested by the controller to be processed in the service request, which returns a model that is modified by the controller to become a viewmodel to display on the views. 

This project written is primarily in C# and C#html (Razor).

