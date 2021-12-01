using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practice_9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Student[] _students = new Student[10];
        private int _indexOfStudent;

        private static DataTable ToDataTable(Student[] students)
        {
            var table = new DataTable();

            table.Columns.Add("Фамилия", typeof(string));
            table.Columns.Add("Общежитие", typeof(bool));
            table.Columns.Add("Опыт", typeof(string));
            table.Columns.Add("Работал ли", typeof(bool));
            table.Columns.Add("Образование", typeof(string));
            table.Columns.Add("Язык", typeof(string));

            for (int i = 0; i < students.Length; i++)
            {
                var row = table.NewRow();
                row.ItemArray = new object[] { students[i].Surname, students[i].HostelNeed, students[i].Background, students[i].DidWork, students[i].Degree, students[i].Language };
                table.Rows.Add(row);
            }
            return table;
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            _students[_indexOfStudent] = new Student(surenameInput.Text, (bool)hostelCheck.IsChecked, int.Parse(backgroundInput.Text), (bool)workCheck.IsChecked, degreeInput.Text, languageInput.Text);
            dataGridMain.ItemsSource = ToDataTable(_students).DefaultView;
            _indexOfStudent++;
        }

        private void Calcualtion_Click(object sender, RoutedEventArgs e)
        {
            var reuslt = 0;
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].HostelNeed)
                {
                    reuslt++;
                }
            }
            MessageBox.Show($"Кол-во студентов нуждающихся в общежитии - {reuslt}");
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Гаврюшин К. А. ИСП-34.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
