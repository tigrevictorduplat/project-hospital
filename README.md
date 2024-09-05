# Hospital Project

## Summary
- [**Objective**](/README(pt-br).md/#objetivo)
- [**Description**](/README(pt-br).md/#descrição)
- [**Demonstrations**](/README(pt-br).md/#demonstração-do-programa)
- [**System Windows**](/README(pt-br).md/#janelas-do-sistema)
***

## Objective 🎯
This project simulates a Hospital reception system and includes:
- Client Registration
- User Registration
  
The users are:  
- Doctor
- Patient
- Company/Employee

Through an integration between a *Relational Database* (**MySQL**) and *Forms Windows* (**C#**), we will have a basic system for client registration and service usage.

## Description 🖊️

### Client Table
A table that stores the information of potential hospital clients (patients).

Field | Data Type | +
---|---|---
⭐CPF | VARCHAR(11) | Primary Key
Client Name | VARCHAR(45) | ---
Registration Date | DATE TIME | ---
Health Insurance | VARCHAR(45) | Can be null

### User Table
A table that stores information about possible hospital users (doctors, recurring patients, companies, or beneficiaries).

Field | Data Type | +
---|---|---
⭐ID | INT | Primary Key (Auto Increment)
Username | VARCHAR(45) | ---
Password | VARCHAR(45) | ---
Registration Date | DATE TIME | ---
User Type | VARCHAR(45) | ---

### Services Table
A table that stores information about the available hospital services (Exams, Consultations, Laboratory, Emergency Room).

Field | Data Type | +
---|---|---
⭐ID | INT | Primary Key (Auto Increment)
Service Name | VARCHAR(45) | ---
Service Description | VARCHAR(45) | ---
Service Price | DOUBLE(6,2) | (Default = 0.00)

### Client-Service Relationship (Appointment Table)
Field | Data Type | +
---|---|---
⭐ID | INT | Primary Key (Auto Increment)
Appointment Date | DATE TIME | ---
Service Description | VARCHAR(45) | ---
🔑 Client ID | VARCHAR(11) | Foreign Key
🔑 Service ID | INT | Foreign Key

***
# Program Demonstration

#### ADMConnection Form
<video width=60% alt="ADM Connection Demonstration" src="https://user-images.githubusercontent.com/98099656/228383875-c5ba088c-b148-4af8-89f0-c2a03d9b27c1.mp4"></video>

#### Main Menu
<video width=60% alt="Main Menu Demonstration" src="https://user-images.githubusercontent.com/98099656/228383935-8313269d-6f62-4de2-a515-0981eda174d6.mp4"></video>

***
# System Windows

## ADMConnection Form - Database Connection Window
<img src="/program-demo/ADMConnection.jpg" alt="ADM Connection Window">
This window is responsible for receiving the database connection credentials, which are passed through methods like `setConnection()`. With a design that aligns with the project’s proposal, this is the user’s first interaction with the interface.
