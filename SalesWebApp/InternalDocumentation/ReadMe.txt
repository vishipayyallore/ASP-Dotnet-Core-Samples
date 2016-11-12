Web API URL: http://salesserviceapi.azurewebsites.net/api/Products 
Web Application URL: http://saleswebportal.azurewebsites.net/
Source Code: https://github.com/vishipayyallore/ASP-Dotnet-Core-Samples/tree/master/SalesWebApp 
Read Me Path: https://github.com/vishipayyallore/ASP-Dotnet-Core-Samples/tree/master/SalesWebApp/InternalDocumentation

Step 1:
Update the appsettings.json inside Sales.ServiceApi.

Step 2:
Execute the below mentioned commands
EntityFrameworkCore\Add-Migration eCommerceMigration1
EntityFrameworkCore\Update-Database

Step 3:
Publish the code to Azure Cloud.


'angular-star-rating'