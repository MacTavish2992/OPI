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
using System.Data.Entity;

namespace Sportik
{
    /// <summary>
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        SportDB db;
        public AddClient()
        {
            InitializeComponent();
            db = new SportDB();
            db.Instructor.Load();
            InstructorsList.ItemsSource = db.Instructor.Local.ToList();

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if(NameTextBox.Text == string.Empty || AgeTextBox.Text == string.Empty || PatronumicTextBox.Text == string.Empty || PhoneNumberTextBox.Text == string.Empty || SurnameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Упс, ошибочка!");
            }
            else
            {
                if (InstructorsList.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < InstructorsList.SelectedItems.Count; ++i)
                    {
                        Instructor instructor = InstructorsList.SelectedItems[i] as Instructor;
                        if (instructor != null)
                        {
                            Client newClient = new Client();
                            newClient.Patronymic = PatronumicTextBox.Text;
                            newClient.Name = NameTextBox.Text;
                            newClient.Surname = SurnameTextBox.Text;
                            newClient.Age = Convert.ToInt32(AgeTextBox.Text);
                            newClient.PhoneNumber = PhoneNumberTextBox.Text;
                            newClient.Instructor = instructor;
                            db.Client.Add(newClient);
                            MessageBox.Show("Поздравляем, клиент добавлен!");
                        }
                    }
                }
                else
                    MessageBox.Show("Выберите тренера!");
                db.SaveChanges();
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
