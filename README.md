# DapperMariaDBDemo is an example ASP.NET MVC application that demonstrate the "database first" approach to working with databases using Dapper.
# Go to MariaDB and create database "billingdb": 
CREATE DATABASE billingdb;
# Create table "People" under "billingdb" database:
CREATE TABLE People (
    id INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL
);
# Create the application:
File menu>New>Project>select ASP.NET Core Web App (Model-View-Controller)>Next>Project name "DapperMariaDBDemo">Next>select Framework ".NET 7.0", select Authentication type "none" and Configure for HTTPS>Create.
# Create Model class "Person":
Right-click on the "Models" folder>Add>New Item>select "Class" and name it "Person.cs".
# Add the connection string to be able to connect to MariaDB server:
Navigate to the "appsettings.json" file in the Solution Explorer. In the connection string, you put the name of the database "billingdb". Also enter the password of your own instead of the one provided in this example application.
# Add a few packages to the solution of the application to enable using Dapper and handle the connection to the database. 
Right-click on the solution>Manage NuGet Packages for Solution>Browse Tab. 
Here, there are three important packages to search for and install: "Dapper" and "MySqlConnector".
# Navigate to "HomeController" in the Solution Explorer:
Right-click on “Controllers” folder>Add>Controller>name it "BillingController.cs".
This controller will interact with the “BillingContext” to insert and display data.
