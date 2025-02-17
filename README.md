# optimize-prime

## TABLE OF CONTENTS
[Description](#description)

[How to Use](#how-to-use)

[How to Deploy](#how-to-deploy)

[How to Develop](#how-to-develop)

[Project Structure Overview](#project-structure-overview)

[Apache 2.0 License](#apache-20-license)

## DESCRIPTION
In this repository is a web application for submitting, reviewing, 
and approving pharmacist application information.

## HOW TO USE

The applicant client web front end can be accessed through the root URL which is 
deployed at http://www.optimizeprime.live. The client page
requires authentication through Google to access. 

The administrator interface for viewing applicants can be accessed at 
http://www.optimizeprime.live/dashboard/admin/applicants. 

Accessing the database can be done by creating a connection to port 
5432 using a database tool such as DBeaver.

## HOW TO DEPLOY

Clone a copy of the code from this repository, then deploy the code using the 
following Docker command in the optimize-prime folder:

	docker-compose up --build

## HOW TO DEVELOP

To get the project up and running, install Docker and run the following
Docker command:

	docker-compose up --build
	
Here are the environment variables for the docker-compose and their uses:

	DB_CONNECTION_STRING - Contains the connection string for the database.
	JWT_SIGNING_KEY - Private key for signing Json web token.
	ASPNETCORE_HTTPS_PORT - Port for redirecting insecure requests to HTTPS.
	
For full development, developer dependencies are the following:

	.NET Core SDK
	Visual Studio Code
	Gitlab
	Postman

The following technologies are used in this project:
	
	Node.js
	Angular
	PostgreSQL
	
To update the database schema, first update the model file in the
[Models](prime-dotnet-webapi/Models) folder, and rebuild using:

	docker-compose up --build

To generate a new migration file, run this command:

	dotnet ef database update

Then, to migrate the new model schema over to the database, run the
following command:

	dotnet ef migrations add InitialCreate
	
Your changes will be deployed automatically next time the app starts.

## PROJECT STRUCTURE OVERVIEW

[Link to architecture](documentation/Architecture.md)

[Link to test plan](documentation/TestPlan.md)

[Link to build pipeline](documentation/BuildPipeline.md)

## APACHE 2.0 LICENSE

Copyright 2019 Sierra Systems Group Inc.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.