# Volunteer Backend

## Introduction

This repository houses the backend for Volunteer Connect, a web application crafted using .NET Core and Entity Framework Core. Primarily serving as the backend, it furnishes a RESTful API, extensively documented using Swagger, enabling seamless communication with the frontend.

## Technologies Used

-   .NET Core: A cross-platform framework for building modern cloud-based web applications.
-   Entity Framework Core: A lightweight, extensible, open source and cross-platform version of the popular Entity Framework data access technology.
-   Testing Frameworks: xUnit and Moq.
-   Swagger: An open-source software framework backed by a large ecosystem of tools that helps developers design, build, document, and consume RESTful web services.
-   Docker: A set of platform as a service products that use OS-level virtualization to deliver software in packages called containers.

## Getting Started

1. **Clone the repository**

    Use the following command to clone this repository to your local machine.

    ```bash
    git clone https://github.com/VolunteerConnect/VolunteerBackend.git
    ```

2. **Set up the database**

    Update the `DefaultConnection` string in the `appsettings.json` file with your SQL Server connection details.

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

    The application will start running at `https://localhost:7177`.
