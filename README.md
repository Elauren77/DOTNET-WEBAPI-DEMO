# Dotnet-WebAPI-Demo


## Installation Requirements

 ```bash
 dotnet tool install dotnet-ef
 dotnet add App/App.csproj package Microsoft.EntityFrameworkCore.Design
 dotnet add App/App.csproj package Microsoft.EntityFrameworkCore.Tools
 dotnet add App/App.csproj package Microsoft.EntityFrameworkCore.SQLite
 dotnet ef migrations add InitialCreate
 dotnet ef database update
 ```