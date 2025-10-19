using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace StudentGradeWPF
{
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameInput.Text.Trim();
            if (!int.TryParse(GradeInput.Text.Trim(), out int grade) || grade < 0 || grade > 100)
            {
                MessageBox.Show("❌ Invalid grade! Enter 0-100.", "Error");
                return;
            }

            var existing = students.FirstOrDefault(s => s.Name == name);
            if (existing != null)
                existing.Grade = grade;
            else
                students.Add(new Student { Name = name, Grade = grade });

            NameInput.Clear();
            GradeInput.Clear();
            DisplayAll();
        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayAll();
        }

        private void DisplayAll()
        {
            StudentList.ItemsSource = null;
            StudentList.ItemsSource = students;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchName = SearchInput.Text.Trim();
            var student = students.FirstOrDefault(s => s.Name == searchName);
            if (student != null)
                SearchResult.Text = $"{student.Name}: {student.Grade}";
            else
                SearchResult.Text = "Student not found!";
        }

        private void AverageButton_Click(object sender, RoutedEventArgs e)
        {
            if (students.Count == 0)
            {
                AverageLabel.Text = "No students.";
                return;
            }
            double avg = students.Average(s => s.Grade);
            AverageLabel.Text = $"Average: {avg:F2}";
        }

        private void HighLowButton_Click(object sender, RoutedEventArgs e)
        {
            if (students.Count == 0)
            {
                HighLabel.Text = "N/A";
                LowLabel.Text = "N/A";
                return;
            }
            HighLabel.Text = $"High: {students.Max(s => s.Grade)}";
            LowLabel.Text = $"Low: {students.Min(s => s.Grade)}";
        }
    }

    public class Student
    {
        public string Name { get; set; } = "";
        public int Grade { get; set; }
    }
}
