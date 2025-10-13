using System;
using System.Collections.Generic;
using System.Linq;

partial class Program
{
    static Dictionary<string, int> students = new Dictionary<string, int>();

    static void Main()
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


