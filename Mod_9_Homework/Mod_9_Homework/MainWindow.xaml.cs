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

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> stuList;
        static int currentStudentposition = 0;

        public static int CurrentStudentposition
        {
            get
            {
                return currentStudentposition;
            }

            set
            {
                currentStudentposition = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            stuList = new List<Student>();
            if( CurrentStudentposition >= stuList.Count)
            {
                btnNext.IsEnabled = false;

            }
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student();
            stu.FirstName = txtFirstName.Text;
            stu.LastName = txtLastName.Text;
            stu.City = txtCity.Text;

            MessageBox.Show("Student created !");

            stuList.Add(stu);
            CurrentStudentposition++;

            txtCity.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();

        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            CurrentStudentposition++;
            if (CurrentStudentposition >= stuList.Count)
            {
                txtCity.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                CurrentStudentposition = stuList.Count;
                if (btnNext.IsEnabled)
                {
                    btnNext.IsEnabled = false;
                }
            }
            else
            {
                
                Student stu = stuList[CurrentStudentposition];
                txtLastName.Text = stu.LastName;
                txtFirstName.Text = stu.FirstName;
                txtCity.Text = stu.City;
            }
        
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {

            if( CurrentStudentposition > 0)
            {
                CurrentStudentposition--;
                Student stu = stuList[CurrentStudentposition];
                txtLastName.Text = stu.LastName;
                txtFirstName.Text = stu.FirstName;
                txtCity.Text = stu.City;
                if(!btnNext.IsEnabled)
                {
                    btnNext.IsEnabled = true;
                }

            }

        }
    }
}
