# Project Request
Project Request: an ASP.NET core MVC website project that implements Entity Framework Core for Axia Home Loans

This project make use of Model-View-Controller frame work from ASP.NET Core to generate webpage. 
This project also make use of Entity Core Framework to create Db Context and Db Sets used to communicate with a SQL server.
This project is designed with N-Tier Architechture in mind to divide responsibilities and separate dependencies with Inversion of Control and Dependency Injection.

This project is separated into Data, Model, Service, and Web layer, with each layer serving a purpose and depending on one another. The Database Context uses Dbsets to retrieve data from the database, which is then processed in the service request, and returns an Entity model that is mapped by the Controller into a ViewModel with certain data attributes to display to the Views. The Views Interact with front end Javascript and CSS element to create more interactive User Interfaces and Validations.

Furthermore, I incorporated Azure AD service by modifying appsetting.json and Startup.cs in order to utilize OAuth2.0 to Authenticate users using Microsoft's login service.

Additionally, I created an Email Service that sends email using Smtp and MailAddress configuration in appsetting.json to direct user-created project request entry to our email folders.

Lastly, I imported Serilog NuGet Package and added the configuration inside the Startup.cs file in order to keep track of a rolling log file, separated by Days, that tracks informations regarding different app services and its response time for better debugging and tracking requests.

<h4>Welcome Page:</h4>
<img width="960" alt="Welcome" src="https://user-images.githubusercontent.com/70926365/127692783-4185c197-2a8c-463d-8d4d-65b20f9bbd34.png">

<h4>Signin Page using Azure AD service and Oauth2.0:</h4>
<img width="961" alt="Signin" src="https://user-images.githubusercontent.com/70926365/127692874-2d8d4ed9-1a67-481e-9726-ee1e5db78614.png">

<h4>Index Page:</h4>
<img width="960" alt="Index" src="https://user-images.githubusercontent.com/70926365/127692954-12795c35-d136-4a63-b8be-90eec57d0ac0.png">

<h4>Index Page with Pagination (Separated by 10 Entries):</h4>
<img width="959" alt="IndexAlt" src="https://user-images.githubusercontent.com/70926365/127692991-75c380bc-bddb-4db1-a022-0862189a750f.png">


<h4>Creation Page:</h4>
<img width="959" alt="Create" src="https://user-images.githubusercontent.com/70926365/127692929-c3a710d3-1ae4-404e-85af-27fb31d3112b.png">

<h4>Creation Page with populated fields:</h4>
<img width="960" alt="CreateAlt" src="https://user-images.githubusercontent.com/70926365/127693010-83d9a005-c033-4294-9716-36628b3a03a8.png">

<h4>Edit Page:</h4>
<img width="959" alt="Edit" src="https://user-images.githubusercontent.com/70926365/127693030-31d7fadd-496a-42ed-b07e-61521e922444.png">

<h4>Details Page:</h4>
<img width="960" alt="Details" src="https://user-images.githubusercontent.com/70926365/127693042-e4ac5fb9-c35c-40ae-ae2f-57a1b7e9dfcc.png">

<h4>Delete Page:</h4>
<img width="959" alt="Delete" src="https://user-images.githubusercontent.com/70926365/127693059-e64bc7dd-aa3b-487d-9167-ab84a9c232fc.png">

