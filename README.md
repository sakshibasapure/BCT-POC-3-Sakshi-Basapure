## E-Commerce Backend
An e-commerce bacend application is created with ASP.NET Core 5.0,using SQL Server as database. This page has been created according to the guidelines given for POC 1 by BCT L&D team.


### Tools and Frameworks used 
- ASP .NET Core 5.0
- Policy based Authorization using JWT
- Microsoft SQL Server Mananagement Studio 18
- Microsoft Visual Studio 2019
- Postman

 
 ### SetUp
1. Clone this repository: https://github.com/sakshibasapure/BCT-POC-3-Sakshi-Basapure.git
2. Enter ``` cd eCommerce ``` 
3. Open and click on ```eCommerce.sln``` to build application
4. Put your connection string in appsettings.json file
5. Enter ```dotnet ef database update``` to load schema in database
6. Enter ```dotnet run```
7. Test APIs in Postman with URL https://localhost:5001/

 


