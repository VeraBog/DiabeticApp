using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace DiabeticApp
{
    /// <summary>
    /// Logika interakcji dla klasy Profil.xaml
    /// </summary>
    public partial class Profil : Window
    {
        public Profil()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        private void Profil_Back_button_Click(object sender, RoutedEventArgs e)
        {
            MenuApp a = new MenuApp();
            this.Close();
            a.Show();
        }

        private void Save_profil_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=LAPTOP-MDDJ1L5P\SQLEXPRESS;Database=LRDATABASE;Integrated Security=True");
                con.Open();
                string add_data = "INSERT INTO [dbo].[profil](ID,sex,age,weight) VALUES(IDENT_CURRENT('user'),@sex,@age,@weight)";
                SqlCommand cmd = new SqlCommand(add_data, con);

                
                cmd.Parameters.AddWithValue("@sex", sex.Text);
                cmd.Parameters.AddWithValue("@age", age.Text);
                //cmd.Parameters.AddWithValue("@weight", weight.Text);
                var value = weight.Text.Replace(".", ",");
                //cmd.Parameters.Add("@weight", SqlDbType.Decimal).Value = decimal.Parse(weight.Text);
                decimal weightValue;
                if (decimal.TryParse(value, out weightValue))
                {
                    cmd.Parameters.Add("@weight", SqlDbType.Decimal).Value = weightValue;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Wprowadzono złą wartość");
                }
                //cmd.ExecuteNonQuery();
                con.Close();

                sex.Text = "";
                age.Text = "";
                weight.Text = "";
                

            }
            catch (Exception )
            {
                MessageBox.Show("Wpisz wartość liczbową");
                return;
            }
        }
    }
}
