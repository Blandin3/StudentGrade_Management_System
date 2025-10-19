using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.IO; // ✅ Needed to check if file exists

partial class Program
{
    static Dictionary<string, int> students = new Dictionary<string, int>();

    [STAThread] // Required for WPF
    static void Main()
    {
        Console.WriteLine("=== Student Grade Management System ===");
        Console.WriteLine("Choose UI mode:");
        Console.WriteLine("1. Console UI");
        Console.WriteLine("2. WPF UI");
        Console.Write("Enter choice: ");

        string? uiChoice = Console.ReadLine();
        Console.Clear();

        if (uiChoice == "2")
        {
            Console.WriteLine("Launching WPF UI...");

            // ✅ Full path to the built WPF .exe file
            string wpfAppPath = 
                @"C:\Users\ADMIN\StudentGrade_Management_System\StudentGrade-Management_System\StudentGradeWPF\bin\Debug\net8.0-windows\StudentGradeWPF.exe";

            if (File.Exists(wpfAppPath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = wpfAppPath,
                    UseShellExecute = true
                });
            }
            else
            {
                Console.WriteLine("❌ WPF App not found at:");
                Console.WriteLine(wpfAppPath);
                Console.WriteLine("\n➡ Build the WPF project first using:");
                Console.WriteLine("   cd StudentGradeWPF");
                Console.WriteLine("   dotnet build");
            }

            return; // Exit after trying to launch WPF
        }

        // ✅ Continue running console-based UI if choice = 1
        RunConsoleUI();
    }

    // ========== CONSOLE UI LOOP ==========
    static void RunConsoleUI()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Student Grade Management System ===");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Calculate Average Grade");
            Console.WriteLine("5. Show Highest & Lowest Grades");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string? input = Console.ReadLine();
            string choice = input ?? string.Empty;
            Console.Clear();

            switch (choice)
            {
                case "1": AddStudent(); break;
                case "2": DisplayAll(); break;
                case "3": SearchStudent(); break;
                case "4": CalculateAverage(); break;
                case "5": ShowHighLow(); break;
                case "6": return;
                default: Console.WriteLine("Invalid choice! Try again."); break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    // ========== OTHER FUNCTIONS ==========
    static void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter student grade (0–100): ");
        try
        {
            string? gradeInput = Console.ReadLine();
            if (gradeInput == null)
            {
                Console.WriteLine("❌ Invalid grade input! Please enter a number.");
                return;
            }
            int grade = int.Parse(gradeInput);
            students[name] = grade;
            Console.WriteLine("✅ Student added successfully!");
        }
        catch (FormatException)
        {
            Console.WriteLine("❌ Invalid grade input! Please enter a number.");
        }
    }

    static void DisplayAll()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students available.");
            return;
        }

        Console.WriteLine("All Students and Grades:");
        foreach (var s in students)
            Console.WriteLine($"{s.Key}: {s.Value}");
    }

    static void SearchStudent()
    {
        Console.Write("Enter student name to search: ");
        string name = Console.ReadLine() ?? string.Empty;

        if (students.ContainsKey(name))
            Console.WriteLine($"{name}'s grade: {students[name]}");
        else
            Console.WriteLine("Student not found!");
    }

    static void CalculateAverage()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No grades available.");
            return;
        }

        double average = students.Values.Average();
        Console.WriteLine($"Average Grade: {average:F2}");
    }

    static void ShowHighLow()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No grades available.");
            return;
        }

        int highest = students.Values.Max();
        int lowest = students.Values.Min();

        Console.WriteLine($"Highest Grade: {highest}");
        Console.WriteLine($"Lowest Grade: {lowest}");
    }
}
