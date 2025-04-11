<h1 align="center">Containerized ICE Task</h1>

## Team Members 
* [Keely-Ann Maritz](https://github.com/Keely-Ann/)
* [Wiehan Smalberger](https://github.com/wiehan007)

<br>

## Team Member Contribution
### Keely-Ann
* init-database.sql
* docker-compose.yml
* ProductsConfiguration.cs
* RetailDB Dockerfile
* RetailMVC Dockerfile
* Program.cs
* Products Views (AddProducts, UpdateProducts, DeleteProducts, ViewProducts)
* README File (Team Members, Team Contributions, Decision making Process, Challenges, Resolutions, Instructions)
    

### Wiehan
* Models: Products.cs
* docker-compose.yml
* ApplicationDBConnect
* RetailDB Dockerfile
* RetailMVC Dockerfile
* ProductsController (AddProducts, UpdateProducts, DeleteProducts, ViewProducts)
* README File (Decision making Process, Challenges, Resolutions, Instructions)
  

<br>

## Decision making Process
1. Create database (init-database.sql) through the dockerfiles and docker-compose.yml
2. Directly implemented it into the MVC Appliction with the connection string in the program file, instead of using Entity Framework.

<br>

## Challenges
1. When attempting to build the database via the command line, we encountered a table name problem since one of the column names, "ProductName", did not match what was intended.
2. We had trouble implementing the connection to the database using Entity Framework 

<br>

## How the challenges were resolved
* We resolved the challenge by changing the column name from 'Name' to 'ProductName' and it broke further. We changed the column name back to 'Name' and tried rerunning the script. The database had been built successfully.
* We realized we did not need to implement Entity Framework the traditional way, by running the dbcontext scaffold command using the connection string, and called the environmental variable in the program file, which had the connection string.

<br>

## Instructions on how to run the application 
1. Download the GitHub repository or clone the repository.
2. Open the project in Visual Studio.
3. Make sure Docker is open and running. 
4. Click on Tools -> Command Line -> Developer Command Prompt
5. Assuming you have nothing running in Docker (no containers, no images, no volumes) Run the <b>docker-compose up --build<b>
6. Run the application 

<br>

