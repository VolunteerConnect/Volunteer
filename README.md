# Volunteer

## Description

This is a volunteer app that allows users to create an account and sign up for volunteer opportunities.
To find out more about the project, please visit the documentation of the frontend and backend repositories.

-   [Frontend](https://github.com/VolunteerConnect/VolunteerFrontend/blob/main/README.md)
-   [Backend](https://github.com/VolunteerConnect/Volunteer/blob/main/VolunteerBackend/README.md)

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.
First, clone the repository to your local machine:

```bash
git clone https://github.com/VolunteerConnect/Volunteer
cd Volunteer
git clone https://github.com/VolunteerConnect/VolunteerFrontend
```

Copy the ./volunteerfrontend/.env.local.example file to ./volunteerfrontend/.env.local using the following command:

```bash
cp ./volunteerfrontend/.env.local.example ./volunteerfrontend/.env.local
```

Fill in the following variables in ./volunteerfrontend/.env.local:

```plaintext
AUTH0_SECRET=
AUTH0_BASE_URL='http://localhost:3000/'
AUTH0_ISSUER_BASE_URL=
AUTH0_CLIENT_ID=
AUTH0_CLIENT_SECRET=
NEXT_PUBLIC_API_BASE_URL=http://localhost:80/api
```

If needed, change the ./voluteerbackend/volunteer.api/appsettings.json file.

To start the application for development, run the following command:

```bash
    docker-compose up -d
```

To start the application for production, run the following command:

```bash
    docker-compose -f docker-compose.prod.yml up -d
```

To stop the application, run the following command:

```bash
    docker-compose down
```

## Definition of Done

-   Code follows coding standards and best practices.
-   All code related to the user story or feature is written and reviewed.
-   Code has been reviewed by at least one other team member for quality, correctness, and adherence to coding standards.
-   Any identified issues or improvements have been addressed.
-   The user story or feature has undergone user acceptance testing by stakeholders or users.
-   There are no known defects or critical issues related to the user story or feature.
-   The code is ready for deployment to the production environment.

## User Story

**As a potential volunteer, I want to see an overview of non-profit organizations so that I can choose which organization I want to assist.**

**Acceptance Criteria**

-   I should see a list of 5 non-profit organizations with their names, brief descriptions and a picture or logo.
