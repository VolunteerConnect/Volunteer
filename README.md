# Project Name

## Introduction

This project is a web application built with .NET Core and Entity Framework Core.

## Technologies Used

-   .NET Core: A cross-platform framework for building modern cloud-based web applications.
-   Entity Framework Core: A lightweight, extensible, open source and cross-platform version of the popular Entity Framework data access technology.

## Getting Started

1. **Clone the repository**

    Use the following command to clone this repository to your local machine.

    ```bash
    git clone https://github.com/VolunteerConnect/VolunteerBackend
    ```

2. **Set up the database**
   Update the `DefaultConnection` string in the `appsettings.json` file with your database connection string.

    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
    }
    ```

3. **Run the application**
   Navigate to the project directory and run the following command to start the application.

    ```bash
    dotnet run
    ```
