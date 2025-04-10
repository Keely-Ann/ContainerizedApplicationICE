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
* README File (Team Members, Team Contributions, Decision making Process, Challenges, Resolutions, Instructions)
    

### Wiehan
* Models: Products.cs
* docker-compose.yml
* ApplicationDBConnect
* RetailDB Dockerfile
* RetailMVC Dockerfile
* README File (Decision making Process, Challenges, Resolutions, Instructions)
  

<br>

## Decision making Process
* Implement an API with the CRUD methods or create the CRUD methods directly in the RetailMVC project.

<br>

## Challenges
1. When attempting to build the database via the command line, we encountered a table name problem since one of the column names, "ProductName", did not match what was intended. 

<br>

## How the challenges were resolved
* We resolved the challenge by changing the column name from 'Name' to 'ProductName' and it broke further. We changed the column name back to 'Name' and tried rerunning the script. The database had been built successfully.

<br>

## Instructions on how to run the application 


<br>

