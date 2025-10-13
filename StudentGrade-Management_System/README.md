# Student Grade Management System

A simple, interactive C# console application for managing student grades. This project allows users to add students, display all students, search for a student, calculate the average grade, and find the highest and lowest grades among students.

## Features

- **Add Student:** Enter a student's name and grade (0–100) to add them to the system.
- **Display All Students:** View a list of all students and their grades.
- **Search Student:** Find a student's grade by entering their name.
- **Calculate Average Grade:** Compute and display the average grade of all students.
- **Find Highest and Lowest Grades:** Display the highest and lowest grades among all students.
- **Exit:** Quit the application.

## How It Works

The application uses a `Dictionary<string, int>` to store student names and their corresponding grades. It presents a menu-driven interface, allowing users to select actions by entering the corresponding number. Input validation ensures grades are between 0 and 100, and handles invalid or empty inputs gracefully.

## Usage

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later installed on your system.

### Running the Application

1. **Clone or Download the Repository**
   - Place the project folder on your machine.

2. **Navigate to the Project Directory**
   ```sh
   cd StudentGrade-Management_System/StudentGradeManagement
   ```

3. **Build the Project**
   ```sh
   dotnet build
   ```

4. **Run the Application**
   ```sh
   dotnet run
   ```

5. **Follow the On-Screen Menu**
   - Enter the number corresponding to the action you want to perform.
   - Input student names and grades as prompted.

## Example Menu
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
- Student names are case-sensitive.
- The application runs in a loop until you choose to exit.

## License
This project is open source and free to use for educational purposes.
