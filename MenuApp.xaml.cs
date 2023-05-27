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

namespace DiabeticApp
{
    /// <summary>
    /// Logika interakcji dla klasy MenuApp.xaml
    /// </summary>
    public partial class MenuApp : Window
    {
        public MenuApp()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        

        private void Day_button_Click(object sender, RoutedEventArgs e)
        {
            Day d1 = new Day();
            this.Close();
            d1.Show();

        }

        private void Week_button_Click(object sender, RoutedEventArgs e)
        {
            Week we1 = new Week();
            this.Close();
            we1.Show();
        }

        private void Month_button_Click(object sender, RoutedEventArgs e)
        {
            Month m1 = new Month();
            this.Close();
            m1.Show();
        }


        private void Logout_btt_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w1 = new MainWindow();
            this.Close();
            w1.Show();
        }

        private void Profil_button_Click(object sender, RoutedEventArgs e)
        {
            Profil p1 = new Profil();
            this.Close();
            p1.Show();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=LAPTOP-MDDJ1L5P\SQLEXPRESS;Database=LRDATABASE;Integrated Security=True");
                con.Open();
                string add_data = "INSERT INTO [dbo].[Sugar](ID,sugar,calories,activity,carbs,protein,fat) VALUES(IDENT_CURRENT('user'),@sugar,@calories,@activity,@carbs,@protein,@fat)";
                SqlCommand cmd = new SqlCommand(add_data, con);


               
                 cmd.Parameters.AddWithValue("@sugar", Sugar.Text);
                /*float SugarV;
                if (float.TryParse(Sugar.Text, out SugarV))
                {
                    cmd.Parameters.AddWithValue("@sugar", SugarV);
                }
                else
                {
                    Wynik_pole.Text = "Wprowadzono niepoprawną wartość poziomu cukru we krwi!";
                    return;
                }*/
                 cmd.Parameters.AddWithValue("@calories", calories.Text);
               /* float caloriesValue;
                if (float.TryParse(calories.Text, out caloriesValue))
                {
                    cmd.Parameters.AddWithValue("@calories", caloriesValue);
                }
                else
                {
                    Wynik_pole.Text = "Wprowadzono niepoprawną wartość kalorii!";
                    return;
                }*/
                cmd.Parameters.AddWithValue("@activity", activity.Text);
                cmd.Parameters.AddWithValue("@carbs", carbs.Text);
                cmd.Parameters.AddWithValue("@protein", protein.Text);
                cmd.Parameters.AddWithValue("@fat", fat.Text);
                cmd.ExecuteNonQuery();
                con.Close();

               // Sugar.Text = "";
                calories.Text = "";
                activity.Text = "";
                carbs.Text = "";
                protein.Text = "";
                fat.Text = "";


               // void CalculateInsulinUnits()
              //  {
                    float bloodSugar;
                    if (float.TryParse(Sugar.Text, out bloodSugar) && bloodSugar > 0)
                    {
                        float targetBloodSugar = 100;
                        float difference = bloodSugar - targetBloodSugar;
                        float insulinUnits = difference / 30;
                        Wynik_pole.Text = " jednostki insuliny: " + insulinUnits.ToString("0.00");
                }
                    else
                    {
                        Wynik_pole.Text = " Niepoprawna wartość poziomu cukru!";
                    }
               //}

                

            }
            catch (Exception)
            {
                MessageBox.Show("Wpisz wartość liczbową");
                return;
            }
        }
    }
}
