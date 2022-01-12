# CLI Commands REST API (.NET 6 MVC)
**This API stores and returns command line snippets, a short description of what they do and what platform they are for**
### The purpose of this project is to learn and practice concepts related to:
> - .NET 6
> - Building a REST API
> - C#
> - MVC Architectural Pattern
#### More specifically, I familiarized myself with the following:
> - Dependency injection
> - Repository design pattern
> - SQL Server Express & SSMS
> - Entity Framework Core O/RM (DBContext, Migration, Seeding)
> - Data Transfer Objects (DTOs) & AutoMapper
> - RESTful API guidelines
> - HTTP (GET, POST, PUT, PATCH, DELETE, status codes)
> - Testing API Endpoints (SwaggerUI & Postman)
> - Docker (Containerization, Images, Compose, Docker Hub)

### Table of Contents
**[Application Architecture](#application-architecture)**<br>
**[API Endpoints](#api-endpoints)**<br>
**[User Interface](#user-interface)**<br>
**[Examples using Postman](#examples-using-postman)**<br>
**[Try it out](#try-it-out)**<br>

## Application Architecture
![image](https://github.com/nasif-mahmood/.NET6-MVC-REST-API/blob/master/images/architecture.png)

## API Endpoints
![image](https://github.com/nasif-mahmood/.NET6-MVC-REST-API/blob/master/images/apiendpoints.png)

## User Interface
![image](https://github.com/nasif-mahmood/.NET6-MVC-REST-API/blob/master/images/ui.png)

## Examples using Postman
### GET
![image](https://github.com/nasif-mahmood/.NET6-MVC-REST-API/blob/master/images/get.png)
### POST
![image](https://github.com/nasif-mahmood/.NET6-MVC-REST-API/blob/master/images/post.png)
### PUT
![image](https://github.com/nasif-mahmood/.NET6-MVC-REST-API/blob/master/images/put1.png)
![image](https://github.com/nasif-mahmood/.NET6-MVC-REST-API/blob/master/images/put2.png)
### PATCH
![image](https://github.com/nasif-mahmood/.NET6-MVC-REST-API/blob/master/images/patch1.png)
![image](https://github.com/nasif-mahmood/.NET6-MVC-REST-API/blob/master/images/patch2.png)
### DELETE
![image](https://github.com/nasif-mahmood/.NET6-MVC-REST-API/blob/master/images/delete1.png)
![image](https://github.com/nasif-mahmood/.NET6-MVC-REST-API/blob/master/images/delete2.png)

## Try it out
*I wanted to have this hosted on a website using a cloud service like Microsoft Azure or AWS but due to the costs, I wouldn't be able to keep it up for a long time. Instead, I've decided to provide instructions for running the API locally.*  
### Prerequisites
- A web browser (Google Chrome, Firefox, Safari, etc.)
- Docker [Installation Instructions](https://docs.docker.com/get-docker/)

### Instructions
1. Download the docker-compose.yml file (you can get it from the [releases](https://github.com/nasif-mahmood/.NET6-MVC-REST-API/releases))
2. Open a terminal in the directory with the file and run **docker-compose up** to start the container
3. You may now navigate to http://localhost:8080/index.html to interact with the Commander API
4. Alternatively, you can use Postman or another API platform to interact with the Commander API as well

