# Student Grade Management System

A simple, interactive C# application for managing student grades. The repository includes two interfaces:

- A console application (`StudentGradeManagement`) with a menu-driven UI.
- A Windows Presentation Foundation (WPF) graphical UI (`StudentGradeWPF`).

## Features

- **Add Student:** Enter a student's name and grade (0–100) to add them to the system.
- **Display All Students:** View a list of all students and their grades.
- **Search Student:** Find a student's grade by entering their name.
- **Calculate Average Grade:** Compute and display the average grade of all students.
- **Find Highest and Lowest Grades:** Display the highest and lowest grades among all students.
- **Exit:** Quit the application.

## How It Works

Both projects share the same core logic for storing and computing student grades. The console project exposes that functionality via a text menu, while the WPF project presents it in a graphical form (windows, buttons and lists).

## WPF UI (Graphical Interface)

What it is
- The `StudentGradeWPF` project is a Windows Presentation Foundation (WPF) frontend that provides a graphical interface to the same student-grade functionality found in the console app. It offers a more user-friendly experience with clickable controls and visual lists.

Special notes
- Windows-only: WPF requires Windows and a .NET runtime that supports `net8.0-windows`.
- The UI lets you add, view and search students and shows summary information (average, highest, lowest) using standard WPF controls.

How to run the WPF UI

Recommended (Visual Studio)
1. Open `StudentGrade-Management_System.sln` in Visual Studio (2022 or later).
2. Set `StudentGradeWPF` as the startup project.
3. Build and run (F5).

Using the .NET CLI (PowerShell)
1. Open PowerShell and navigate to the WPF project folder:
```powershell
cd .\StudentGradeWPF
```
2. Build and run the WPF project:
```powershell
dotnet build -c Debug
dotnet run
```

If you prefer to run directly from the solution root with an explicit project target:
```powershell
dotnet run --project .\StudentGradeWPF\StudentGradeWPF.csproj
```

## Usage (Console App)

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later installed on your system.

### Running the Console Application

1. **Navigate to the Project Directory**
```powershell
cd .\StudentGradeManagement
```
2. **Build and Run**
```powershell
dotnet build
dotnet run
```

3. **Follow the On-Screen Menu**
- Enter the number corresponding to the action you want to perform.
- Input student names and grades as prompted.

## Example Menu (Console)
```
=== Student Grade Management System ===
1. Add Student
2. Display All Students
3. Search Student
4. Calculate Average Grade
5. Find Highest and Lowest Grades
6. Exit
Choose an option:
```

## Notes
- Grades must be integers between 0 and 100.
- Student names are case-sensitive in the console app.
- The WPF UI provides a more discoverable and clickable interface and is intended for Windows desktops.

## License
This project is open source and free to use for educational purposes.
