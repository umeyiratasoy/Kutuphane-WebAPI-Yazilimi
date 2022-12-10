# <p align="center">Car Project</p>
Daily car rental simulation. </br>
The project was developed in accordance with SOLID, Enterprise Software Architecture, AOP and Software Development Principles.

<div align="center">
   <a href = "https://www.linkedin.com/in/umeyir-atasoy/"><img  src = "https://marka-logo.com/wp-content/uploads/2020/04/Linkedin-Logo.png" width = "85" height = "50" alt = "My Linkedin Profile"/></a>
<div>



## Technologies, Frameworks and Best Practices

  * ASP.Net 
  * OOP
  * SQL Server
  * N Layered Architecture (Entity, Data Access, Business, WebAPI, Core)
  * Desing Patterns
  * Entity Framework 
  * IoC
  * Autofac
  * FluentValidation (for building validation rules)
  * JWT (Authentication), Hashing and Salting

## Getting Started

### Installation

1. Clone the repo:

   ```sh
   git clone https://github.com/umeyiratasoy/ReCapProject.git
   ```
2. Open the `ReCapProject.sln` file with `Visual Studio`
3. Integrate the `ReCapProject.sql` file into the database.
4. Open the `ReCapProjectContext.cs` file in the `DataAccess.Concrete.EntityFramework` folder and enter your own database connection string

   
5. Right click on the `WebAPI` project (layer) from the `Solution Explorer` and select `Set as Startup Project` 
6. Start the project with `IIS Express` in Visual Studio. Web API is ready and running!

### Usage
 
After running the Web API, you can make HTTP requests like:
   
   ```sh
   https://localhost:44317/api/`CONTROLLER_NAME`/`METHOD_NAME`
   ```
 
   `CONTROLLER_NAME` => Each .cs file located in the `WebAPI.Controllers` folder (For example CONTROLLER_NAME for `CarsController`: cars )
   <br><br>
   `METHOD_NAME` => All of the methods in each .cs file in the `WebAPI.Controllers` folder
 
#### Sample HTTP GET requests:

1. List all vehicles:
   ```sh
   https://localhost:44317/api/cars/getall
   ```
2. List a brand by id:
   ```sh
   https://localhost:44317/api/brands/getbyid?id=1
   ```
3. List all vehicle colors:
   ```sh
   https://localhost:44317/api/colors/getall
   ```

## Tech Stack
| Technology / Library | Version |
| ------------- | ------------- |
| .NET | 5.0 |
| Autofac | 6.2.0 |
| Autofac.Extensions.DependencyInjection | 7.1.0 |
| Autofac.Extras.DynamicProxy | 6.0.0 |
| FluentValidation | 10.3.0 |
| Microsoft.AspNetCore.Authentication.JwtBearer | 5.0.9 |
| Microsoft.AspNetCore.Http | 2.2.2 |
| Microsoft.AspNetCore.Http.Abstractions | 2.2.0 |
| Microsoft.AspNetCore.Features | 5.0.9 |
| Microsoft.EntityFrameworkCore.Design | 5.0.8 |
| Microsoft.EntityFrameworkCore.SqlServer | 5.0.8 |
| Microsoft.EntityFrameworkCore.Configuration | 5.0.0 |
| Microsoft.EntityFrameworkCore.Configuration.Binder | 5.0.0 |
| Microsoft.IdentityModel.Tokens | 6.12.2 |
| Mime-Detective | 22.7.16 |
| Newtonsoft.Json | 10.0.1 |

## Contributions

Thanks to dear [Engin Demiroğ](https://github.com/engindemirog) for his contributions.