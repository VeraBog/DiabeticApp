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
using LiveCharts;
using LiveCharts.Wpf;
using System.Data.SqlClient;
using System.Linq;

namespace DiabeticApp
{
    /// <summary>
    /// Logika interakcji dla klasy Week.xaml
    /// </summary>
    public partial class Week : Window
    {
        public Week()
        {
            InitializeComponent();
           // ResizeMode = ResizeMode.NoResize;
        }

        private void Week_Back_button_Click(object sender, RoutedEventArgs e)
        {
            MenuApp ma3 = new MenuApp();
            this.Close();
            ma3.Show();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            MyChart.Width = ActualWidth;
            MyChart.Height = ActualHeight;
        }

        private void MyChart_Loaded(object sender, RoutedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Server=LAPTOP-MDDJ1L5P\SQLEXPRESS;Database=LRDATABASE;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT activity,dateS FROM Sugar", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var activityValues = new ChartValues<double>();
                        var dateValues = new ChartValues<DateTime>();

                        int dateSIndex = reader.GetOrdinal("dateS");
                        while (reader.Read())
                        {
                            //sugarValues.Add(reader.GetDouble(0));
                            activityValues.Add(Convert.ToDouble(reader.GetInt32(0)));
                            dateValues.Add(reader.GetDateTime(dateSIndex));
                            //dateValues.Add(reader.GetDateTime(0));
                            //dateValues.Add(reader.GetDateTime(1).ToShortDateString());
                        }
                        var series = new LineSeries
                        {
                            Title = "Activity Time",
                            Values = activityValues,
                            PointGeometry = null


                        };
                        MyChart.Series.Add(series);

                        MyChart.AxisY.Add(new LiveCharts.Wpf.Axis
                        {
                            Title = "Czas aktywności [s]"
                        });

                        MyChart.AxisX.Add(new LiveCharts.Wpf.Axis

                        {
                            Title = "Data pomiaru",
                            // Labels = (IList<string>)dateValues
                            Labels = dateValues.Select(x => x.ToShortDateString()).ToList()
                        });


                        //<lvc:CartesianChart Name="MyChart" Width="700" Height="350" Margin="20, 20, 20, 20" Loaded="MyChart_Loaded" />
                        //MyChart.AxisX.LabelFormatter = value => new DateTime((long)value).ToString("dd/MM/yyyy");
                    }
                }
            }

        }
    }
}
