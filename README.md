# exam-laboratory-codes-app
App created to make easier the process of consult specific lab-exams reference codes based on user common words


## Business Case

## target

- We will improve the experience of end-users and local users, interacting with TheOrganization when requesting Laboratory Exams reference codes.
- For software users and potential customers/end-users
- End-users are struggling when trying to find lab-exams reference codes online and over the phone, because an excel file is not efficient, too large, and difficult to read
- Solving this problem, will be good to TheOrganization because:
    - Will improve the overall experience of end-users and local users, looking for specific lab-exame codes
    - Will reduce the overall time over the phone
    - End-Users will find the code directly in TheOrganization portal instead of using a huge pdf/excel file
    - The local user will be able to set-up an appointment over the phone during a call
    - the local user will be able to close a potential sale
    - The End-user will trust that the requested lab-exame code is referring to what they really require

### Problem Definition

- Not able to find Lab Exam Reference Codes in the Excel/Pdf file
    - As a consequence TheOrganization will not be able to close a potential business opportunity
- Taking longer that required to find Lab Exam Reference Codes in the Excel/Pdf file
- Potential patients/customer/end-users not able to find Lab Exam Reference Codes to provide over the phone
    - As a consecuence the potential patient/customer/end-users will not be able to set-up an appointment
- Bad experience to potential patients/customer/end-users 


### Problem Analysis

- The problem is observed when potential patients/customer/end-users call to TheOrganization to 
    - Validate the price of specific Laboratory exams
    - Set-up an appointment for the take of 

### Potencial Solution



## Diagram


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


### EF Libs and packages

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



## Project 

- clone
- `dotnet restore`
- `dotnet build`
- `dotnet ef migrations add InitialCreate1`
- Update the stringConnection (in appsettings.json or Program.cs)
- `dotnet ef database update`
- `dotnet run`
- endpoint: `{host}/api/LabExam`


