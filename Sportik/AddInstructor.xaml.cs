using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Sportik
{
    /// <summary>
    /// Логика взаимодействия для AddInstructor.xaml
    /// </summary>
    public partial class AddInstructor : Window
    {
        SportDB db;
        public AddInstructor()
        {
            InitializeComponent();
            db = new SportDB();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if(NameTextBox.Text == string.Empty || AgeTextBox.Text == string.Empty || SurnameTextBox.Text == string.Empty || PatronumicTextBox.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                Instructor instructor = new Instructor();
                instructor.Patronymic = PatronumicTextBox.Text;
                instructor.Name = NameTextBox.Text;
                instructor.Surname = SurnameTextBox.Text;
                instructor.Age = Convert.ToInt32(AgeTextBox.Text);
                db.Instructor.Add(instructor);
                db.SaveChanges();
                MessageBox.Show("Инструктор, по воли божьей, добавлен!");
            }    
          
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }
    }
}
