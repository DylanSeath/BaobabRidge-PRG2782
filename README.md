// Baobab Ridge Wildlife Rehabilitation Records System

//Project Information
Module: PRG282
Year: 2026

//Description

BaobaRidge Wildlife Reserve Management System

BaobaRidge is a C# Windows Forms desktop application designed for managing animal records at a wildlife reserve. It provides a simple, structured interface for park rangers and staff to register, update, search, delete, and evaluate the recovery status of reserve animals. 


//Technologies
-C#
-Windows Forms
-.NET 10.0
-Git and GitHub

//Team Members
-	Gontlafetse Maseng 604485
-	Deneishin Prins 603810
-	Stephen Maraya 604893
-	Dylan Seath 603861

//Features

-Add Animal
-View Animals
-Update Animal
-Delete Animal
-Generate Summary Report

--------------------------------------------------
It consists of a form with these features:

Animal Registration (Adding and animal):
•	Input animal details including ID, Name, Species, Age, and Recovery Score.
•	Automatic validation to prevent duplicate Animal IDs.
•	Format validation to enforce the strict “WR-0000” ID format that ensures the ID consists of WR followed by 4 digits

Status Classification:
•	Calculates and assigns animal health status and housing units based on the  Recovery Score entered by the user.

Data Search Function
•	Allows searching by Animal ID.
•	Populates animal details back into the table in the user interface input fields upon a matched search result.
  

Record Management (Update & Delete):
•	Edit existing animal information after fully validating each field and updates the text file.
•	Safely removes animal records with confirmation prompt to ensure that the user does not accidently delete record


Data Handling:
- The system uses a text file to manage animal records.
- Animal information is loaded and displayed in a DataGridView.
- Users can add, search, update and delete animal records.
- Input validation ensures that animal information is entered correctly.
- Changes made to animal records are saved to the text file.


Summary Reporting:
- Generates a summary report of registered animals.
- Displays the total number of animals.
- Calculates the average age of the animals.
- Calculates the average recovery score.
- Displays the number of animals in each recovery category.
- Helps staff monitor animal recovery progress.
  

//File Storage
- Animal records are stored in a text file named animals.txt.
- Uses file handling to read and write animal information.
- Records are stored locally without requiring a database.
- Updated animal information is saved to the text file.
- Deleted animal records are removed from the file.


//How to Run
- Download or clone the project from GitHub.
- Open the project folder in Visual Studio 2026.
- Open the solution file (.slnx).
- Ensure that .NET 10.0 is installed.
- Build the solution.
- Click Start to run the application.
- Use the system to add, view, search, update and delete animals.
- Generate a summary report to view animal statistics.



//Known Limitations
- The application only runs on Windows operating systems.
- Animal records are stored locally in a text file.
- The system does not use a database.
- Multiple users cannot edit records simultaneously.
- The application is designed for small-scale wildlife rehabilitation management.
