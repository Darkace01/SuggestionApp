# Suggestion App - A .NET 6 Blazor WebAssembly Project

This project is a simple suggestion box application built using .NET 6 Blazor WebAssembly and MongoDB, with authentication provided by Azure B2C. Users can submit suggestions and the administrator can approve or reject them. The application is deployed on Azure App Service using GitHub Actions.

## Prerequisites

Before you start using this project, you need to have the following software and services set up:

.NET 6 SDK
MongoDB
Azure B2C Tenant
Azure App Service
GitHub Actions

## Getting Started

### Clone the repository

`git clone https://github.com/Darkace01/SuggestionApp.git`

### Go to the project directory

`cd SuggestionApp`

### Restore the packages

`dotnet restore`

### Update the Connection String and Azure B2C Settings

In the appsettings.json file, update the MongoDbConnection with your MongoDB connection string, and update the ClientId and Instance in the AzureAdB2c section with your Azure B2C tenant information.

### Deploy to Azure App Service

The project is set up to use GitHub Actions for continuous deployment to Azure App Service. You will need to set up a workflow in your GitHub repository and configure it to deploy the application to your Azure App Service.

### Usage

Once the application is deployed and running, users can log in with their Azure B2C credentials and submit suggestions. The administrator can log in and view the suggestions, approving or rejecting them as necessary.
