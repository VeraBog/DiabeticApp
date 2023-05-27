using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace DiabeticApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        private void Login_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=LAPTOP-MDDJ1L5P\SQLEXPRESS;Database=LRDATABASE;Integrated Security=True");
                con.Open();
                string add_data = "SELECT * FROM [dbo].[user] WHERE username=@username AND Password=@password";
                SqlCommand cmd = new SqlCommand(add_data, con);

                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", Password.Password);
                cmd.ExecuteNonQuery();
                int Count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                username.Text = "";
                Password.Password = "";
                if (Count > 0)
                {
                    MenuApp MP = new MenuApp();
                    this.Close();
                    MP.Show();
                }
                else
                {
                    MessageBox.Show("Password or Username is not correct!");
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Register_button_Click(object sender, RoutedEventArgs e)
        {
            Register r1 = new Register();
            this.Close();
            r1.Show();
        }

        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
