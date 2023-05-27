using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace DiabeticApp
{
    /// <summary>
    /// Logika interakcji dla klasy Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        private void Register_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=LAPTOP-MDDJ1L5P\SQLEXPRESS;Database=LRDATABASE;Integrated Security=True");
                con.Open();

                string add_data = "INSERT INTO [dbo].[user] VALUES(@username,@password)";
                SqlCommand cmd = new SqlCommand(add_data, con);

                cmd.Parameters.AddWithValue("@username", Username.Text);
                cmd.Parameters.AddWithValue("@password", Password.Password);
                cmd.ExecuteNonQuery();
                con.Close();

                Username.Text = "";
               Password.Password = "";
                MainWindow w1 = new MainWindow();
                this.Close();
                w1.Show();
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void Register_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w1 = new MainWindow();
            this.Close();
            w1.Show();
        }
    }
}
