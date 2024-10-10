# QHRMAssiTest

QHRMAssiTest is an ASP.NET Core MVC application for managing products. This project enables users to add, edit, view, and delete products using Dapper for data access and SQL Server as the database. It includes a simple and responsive UI, built using Bootstrap.

# Table of Contents
Features
Technologies
Getting Started
Database Configuration
Running the Project

# Features
Add new products with name, description, and price.
View product details in a stylish, user-friendly format.
Edit and delete products.
Responsive design 
Dapper used for lightweight data access.
SQL Server database integration.

# Technologies
ASP.NET Core MVC - Framework for building web applications.
Dapper - Lightweight ORM for database interactions.
SQL Server - Relational database management system.
Bootstrap 5 - Front-end framework for responsive design.


# Prerequisites
.NET SDK 6.0+ installed on your machine.
SQL Server (either local or hosted).
Visual Studio or any other IDE that supports ASP.NET Core.

# Installation Steps

1 Clone the repository:
      git clone https://github.com/swapnaliasjadhv/QHRMAssignmentTest
     cd QHRMAssiTest
2 Restore dependencies:
     dotnet restore
3 Configure the database connection string:
     Open appsettings.json in the root directory, and update the connection string:
    json
       {
            "ConnectionStrings": {
              "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
            }
       }

4 Create the database and table:
Ensure you have a SQL Server instance running and create the necessary table:sql
       CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Description NVARCHAR(255),
    Price DECIMAL(18, 2),
    CreatedAt DATETIME DEFAULT GETDATE()
);

# Database Configuration
Connection String: The connection string for SQL Server is managed via the appsettings.json file.
Dapper ORM: Dapper is used for lightweight SQL queries. Ensure that the Products table is created before running the application.
Running the Project

# Running the Project
   Run the project using Visual Studio 
