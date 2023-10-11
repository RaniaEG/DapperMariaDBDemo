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
Navigate to the "appsettings.json" file in the Solution Explorer. In the connection string, you put the name of the database "billingdb". Also enter the password that was used in the MariaDB setup instead of the one provided in this example application.
# Add a few packages to the solution of the application to enable using Dapper and handle the connection to the database. 
Right-click on the solution>Manage NuGet Packages for Solution>Browse Tab. 
Here, there are three important packages to search for and install: "Dapper" and "MySqlConnector".
# Create "PersonRepository" class:
Navigate to "Models" folder in the Solution Explorer.
Right-click on the "Models" folder>Add>New Item>select "Class" and name it "PersonRepository.cs".
In this class, you establish the connection with the database and create "GetAll" and "Insert" methods to interact with the database and its table.
# Create a new view under the "Home" folder
Right-click on the "Home" folder>Add>View>select "Razor View - Empty">name it "Create.cshtml" and call the model "Person.cs" in it.
Then set the layout of the form to use for inserting data into the database.
Navigate to "Index.cshtml" to display the inserted records and call the model "Person.cs" in it.
# Navigate to "HomeController" in the Solution Explorer:
Here, you call in the "PersonRepository.cs" class and its "GetAll" and "Insert" methods.
# Perform Dependency Injection (DI):
Navigate to "Program.cs" in the Solution Explorer.
Here, you configure the connection to the database and register the "PersonRepository.cs" as a service.
# Now, run the application and try it!
