# 55258_54353_51444_54359_53851
#Aplikacyjny projekt zespołowy L2

# Bookstore Management System
This project is a bookstore management system that allows users to add, remove, and edit books as well as manage their account information. The system also keeps track of the purchase history of books for each user.

### Features
Add, remove and edit books in bookstore inventory
Search books
Registry
Logging in
Selling registration
Books ordering registration
Add, remove, edit users in the system
Checking current stock levels

### Getting Started
To get started with the bookstore management system, follow these steps:

Clone the repository to your local machine.
Install the necessary dependencies by running npm install.
Set up a database to store the bookstore and user information.
Update the database connection string.
Run the application by running Bookstore.sln file.

### Technology Used
.ASP.NET MVC
C#
SQL Server
Entity Framework
Docker
GitHub

### Contributors
Milena Okorska
Dominika Zurawska
Oliwia Poreba
Klaudia Slawecka
Aleksander Maciejewski

### Usage
Once the application is up and running, users can perform the following actions:

Add a new book by providing the title, author, genre, and price.
Remove a book from the inventory by selecting it from the list.
Edit the details of a book by selecting it from the list and updating the information.
Add a new user by providing their name.
Remove a user from the system by selecting them from the list.
Edit user account information such as name.

### Tests
A set of unit tests has been prepared for each method. The tests check for each method the scenarios when the data passed to them was correct and not.


### Run Application

#### Requirements
* docker installed
* internet connection
* downloaded application code

#### Start-up
1. Make sure you have the docker engine enabled on your machine
2. Go to the main project directory (Bookstore)
3. run `cd Bookstore`
4. run  `ls`  (there should be a ***docker-compose.yml*** and ***docker-compose.override.yml*** file in this location)
5. run  `docker-compose docker-compose up --build`
6. go to `http://localhost:8080` if not work try `http://localhost:8093`
7. during the first run, it may be required to migrate db carried out from the browser level, but the created volumes will save all data and during next container run it will not be necessary
