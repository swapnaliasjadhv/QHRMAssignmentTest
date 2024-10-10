# QHRMAssiTest

QHRMAssiTest is an ASP.NET Core MVC application for managing products. This project enables users to add, edit, view, and delete products using Dapper for data access and SQL Server as the database. It includes a simple and responsive UI, built using Bootstrap.

# Table of Contents
Features <br />
Technologies <br />
Getting Started <br />
Database Configuration <br />
Running the Project <br />

# Features
Add new products with name, description, and price. <br />
View product details in a stylish, user-friendly format. <br />
Edit and delete products<br />
Responsive design <br />
Dapper used for lightweight data access.<br />
SQL Server database integration.<br />

# Technologies
ASP.NET Core MVC - Framework for building web applications. <br />
Dapper - Lightweight ORM for database interactions. <br />
SQL Server - Relational database management system. <br />
Bootstrap 5 - Front-end framework for responsive design. <br />


# Prerequisites
.NET SDK 6.0+ installed on your machine.<br />
SQL Server (either local or hosted).<br />
Visual Studio or any other IDE that supports ASP.NET Core. <br />

# Installation Steps

1 Clone the repository: <br />
      git clone https://github.com/swapnaliasjadhv/QHRMAssignmentTest <br />
     cd QHRMAssiTest <br />
2 Restore dependencies:
     dotnet restore <br />
3 Configure the database connection string: <br />
     Open appsettings.json in the root directory, and update the connection string: <br />
    json <br />
       {
            "ConnectionStrings": { <br />
              "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;" <br />
            } <br />
       } <br />

4 Create the database and table: <br />
Ensure you have a SQL Server instance running and create the necessary table:sql <br />
       CREATE TABLE Products ( <br />
    Id INT PRIMARY KEY IDENTITY, <br />
    Name NVARCHAR(100), <br />
    Description NVARCHAR(255), <br />
    Price DECIMAL(18, 2), <br />
    CreatedAt DATETIME DEFAULT GETDATE() <br />
); <br />

# Database Configuration
Connection String: The connection string for SQL Server is managed via the appsettings.json file. <br />
Dapper ORM: Dapper is used for lightweight SQL queries. Ensure that the Products table is created before running the application. <br />
Running the Project <br />

# Running the Project
   Run the project using Visual Studio 
