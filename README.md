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
