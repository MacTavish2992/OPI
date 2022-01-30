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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace Sportik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SportDB db;
        public MainWindow()
        {
            InitializeComponent();
            db = new SportDB();
            db.Instructor.Load();
            db.Client.Load();
            InstructorsList.ItemsSource = db.Instructor.Local.ToList();
            ClientsList.ItemsSource = db.Client.Local.ToList();
        }

        private void Instructors_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(InstructorsList.SelectedItems.Count > 0)
            {
                for(int i = 0; i < InstructorsList.SelectedItems.Count; ++i)
                {
                    Instructor instructor = InstructorsList.SelectedItems[i] as Instructor;
                    ClientOfInstructor.ItemsSource = db.Client.Where(x => x.IdInstructor == instructor.IdInstructor).ToList();
                }
            }    
        }

        private void Clients_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ClientsList.SelectedItems.Count > 0)
            {
                for (int i = 0; i < ClientsList.SelectedItems.Count; ++i)
                {
                    Client client = ClientsList.SelectedItems[i] as Client;
                    InstructorOfClient.ItemsSource = db.Instructor.Where(x => x.IdInstructor == client.IdInstructor).ToList();
                }
            }
        }

        private void SearchInstructor_Click(object sender, RoutedEventArgs e)
        {
            var name = db.Instructor.Local.Where(x => x.Name == InstructorNameTextBox.Text);
            var middleName = db.Instructor.Local.Where(x => x.Patronymic == InstructorPatronymicTextBox.Text);
            var surname = db.Instructor.Local.Where(x => x.Surname == InstructorSurnameTextBox.Text);
            IEnumerable<Instructor> instructors = db.Instructor;
            if (name != null)
            {
                instructors = instructors.Where(x => x.Name.Contains(InstructorNameTextBox.Text));
            }
            if (surname != null)
            {
                instructors = instructors.Where(x => x.Surname.Contains(InstructorSurnameTextBox.Text));
            }
            if (middleName != null)
            {
                instructors = instructors.Where(x => x.Patronymic.Contains(InstructorPatronymicTextBox.Text));
            }
            InstructorsList.ItemsSource = instructors;
        }

        private void SearchClient_Click(object sender, RoutedEventArgs e)
        {
            var name = db.Client.Local.Where(x => x.Name == ClientNameTextBox.Text);
            var middleName = db.Client.Local.Where(x => x.Patronymic == ClientPatronymicTextBox.Text);
            var surname = db.Client.Local.Where(x => x.Surname == ClientSurnameTextBox.Text);
            IEnumerable<Client> Clients = db.Client;
            if (name != null)
            {
                Clients = Clients.Where(x => x.Name.Contains(ClientNameTextBox.Text));
            }
            if (surname != null)
            {
                Clients = Clients.Where(x => x.Surname.Contains(ClientSurnameTextBox.Text));
            }
            if (middleName != null)
            {
                Clients = Clients.Where(x => x.Patronymic.Contains(ClientPatronymicTextBox.Text));
            }
            ClientsList.ItemsSource = Clients;
        }

        private void AddInstructor_Click(object sender, RoutedEventArgs e)
        {
            AddInstructor button = new AddInstructor();
            button.Show();
            this.Close();
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            AddClient button = new AddClient();
            button.Show();
            this.Close();
        }
    }
}
