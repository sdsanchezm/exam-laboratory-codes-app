# exam-laboratory-codes-app

- App created to make easier the process of consult specific lab-exams reference codes based on user common words
- The app can be previewed at [https://labexamcodessearch.netlify.app/](https://labexamcodessearch.netlify.app/)

## Repository Description 

- It contains the back-end API of the Front-End at [https://github.com/sdsanchezm/exam-laboratory-codes-front] (written in Typescript using Angular-Bootstrap)
- This repository, contains a Back-End application (API RESTful) written in C# .Net 7 (updated from 6, using webapi).
    - It includes features such as:
        - RESTful API 
        - Service Pattern for scalability
        - Following SOLID Principles
        - Using principles of Clean Code
        - MS SQL Server
        - Entity Framework
        - Queries made with LINQ
        - Optimized for low comsumption memory
        - Optimized and clean Endpoint 
        - Failure tolerant
        - Model Validation


## Business Context

### Objective

- Improve the experience of end-users and local users, interacting with TheOrganization when requesting Laboratory Exams reference codes over the phone or in person. (Internal and External)
- End-users are struggling when trying to find lab-exams reference codes online and over the phone, because an excel file is not efficient, too large, and difficult to read.
- Solving this problem, will be good to TheOrganization because:
    - Will improve the overall experience of end-users and local users, looking for specific lab-exame codes
    - Will reduce the overall time over the phone (from average 10 minutes to 5 minutes or less).
    - End-Users will find the code directly in TheOrganization portal instead of using a huge-sized pdf/excel file.
    - The local user will be able to set-up an appointment or schedule the lab exam over the phone during a quick call.
    - The End-user will trust that the requested lab-exame code is referring to what they really require.


### Problem Definition

- Not able to find Lab Exam Reference Codes in the Excel/Pdf file.
    - As a consequence TheOrganization will not be able to close a potential service opportunity.
- Taking longer that required to find Lab Exam Reference Codes in an Pdf file.
- Potential patients/customer/end-users not able to find Lab Exam Reference Codes to identify/provide over the phone. 
    - As a consecuence the potential patient/customer/end-users will not be able to set-up an appointment.
- Bad experience leading users to use another provider or call one more time, aumenting the number of interactions over the phone.


### Problem Analysis

- The problem is observed when potential patients/customer/end-users call to TheOrganization to 
    - Validate the price of specific Laboratory exams
    - Set-up an appointment for the take of 

### Solution
- This project allows to quickly enter a word or keyword of the common name of an exam and quickly identify the Exam code required. 
- Also, allows to identify the recommendations, preparations and other details of the exam itself.

### Value
- This application allows to reduce the time that a potential client is over the phone in 50% of the time.
- This application, reduce the time in average from 10 minutes over the phone to 5 mins or less over the phone.


## Data fields

- Number
- Name
- CommonName
- fastingRequired
- preparationDescription
- observationForLaboratory
- examPlace
- schedule
- examCode
- cupsCode
- sampleDescription
- sampleStability
- clinicUtility
- mountingDays
- timeResults
- sampleTechnic
- processingPlace


#### Technical Details

- EF `dotnet add package Microsoft.EntityFrameworkCore --version 7.0.3`
    - `dotnet tool install --global dotnet-ef --version 7.0.3`
- EF Relational
    - `dotnet add package Microsoft.EntityFrameworkCore.Relational --version 7.0.3`
- EF SQL Server support
    - `dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.3`
- EF design
    - `dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.3`
- Create Migrtions
    - `dotnet ef migrations add InitialCreate`
- apply migrations to Database
    - `dotnet ef database update`

#### Project 
- clone
    - `dotnet restore`
    - `dotnet build`
    - `dotnet ef migrations add InitialCreate1`
- Update the stringConnection (in appsettings.json or Program.cs)
    - `dotnet ef database update`
    - `dotnet run`


