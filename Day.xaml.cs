using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;
using LiveCharts.Wpf.Charts.Base;


namespace DiabeticApp
{
    /// <summary>
    /// Logika interakcji dla klasy Day.xaml
    /// </summary>
    public partial class Day : Window
    {
         public Day()
         {
             InitializeComponent();
           // ResizeMode = ResizeMode.NoResize;
        }

         private void Day_back_button_Click(object sender, RoutedEventArgs e)
         {
             MenuApp ma1 = new MenuApp();
             this.Close();
             ma1.Show();
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
                using (SqlCommand cmd = new SqlCommand("SELECT weight,dateP FROM Profil", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var weightValues = new ChartValues<double>();
                        var dateValues = new ChartValues<DateTime>();

                        int datePIndex = reader.GetOrdinal("dateP");
                        while (reader.Read())
                        {
                            //sugarValues.Add(reader.GetDouble(0));
                             //weightValues.Add(Convert.ToDouble(reader.GetInt32(0)));
                            //weightValues.Add(Convert.ToDouble(reader.GetDouble(0)));
                             weightValues.Add(Convert.ToDouble(reader.GetDecimal(0)));
                            //weightValues.Add(Convert.ToDouble(Convert.ToInt32(reader.GetDecimal(0))));
                           // weightValues.Add(reader.GetInt32(0));
                            dateValues.Add(reader.GetDateTime(datePIndex));
                            //dateValues.Add(reader.GetDateTime(0));
                            //dateValues.Add(reader.GetDateTime(1).ToShortDateString());
                        }
                        var series = new LineSeries
                        {
                            Title = "Weight",
                            Values = weightValues,
                            PointGeometry = null


                        };
                        MyChart.Series.Add(series);

                        MyChart.AxisY.Add(new LiveCharts.Wpf.Axis
                        {
                            Title = "Waga [kg]"
                        });

                        MyChart.AxisX.Add(new LiveCharts.Wpf.Axis

                        {
                            Title = "Data pomiaru",
                            
                            Labels = dateValues.Select(x => x.ToShortDateString()).ToList()
                        });


                        //<lvc:CartesianChart Name="MyChart" Width="700" Height="350" Margin="20, 20, 20, 20" Loaded="MyChart_Loaded" />
                        //MyChart.AxisX.LabelFormatter = value => new DateTime((long)value).ToString("dd/MM/yyyy");
                    }
                }
            }

        }



        //private void MyChart_Loaded(object sender, RoutedEventArgs e)
        //{
        //    using (SqlConnection con = new SqlConnection(@"Server=LAPTOP-MDDJ1L5P\SQLEXPRESS;Database=LRDATABASE;Integrated Security=True"))
        //    {
        //        con.Open();
        //        string query = "";
        //        if (sugarCheckbox.IsChecked == true)
        //        {
        //            query = "SELECT sugar, dateS FROM Sugar";
        //        }
        //        else if (weightCheckbox.IsChecked == true)
        //        {
        //            query = "SELECT weight, dateS FROM Profil";
        //        }
        //        else if (activityCheckbox.IsChecked == true)
        //        {
        //            query = "SELECT activity, dateS FROM Sugar";
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please select one of the checkboxes.");
        //            return;
        //        }
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                var values = new ChartValues<double>();
        //                var dateValues = new ChartValues<DateTime>();
        //                int dateSIndex = reader.GetOrdinal("dateS");
        //                while (reader.Read())
        //                {
        //                    values.Add(Convert.ToDouble(reader.GetValue(0)));
        //                    dateValues.Add(reader.GetDateTime(dateSIndex));
        //                }
        //                var series = new LineSeries
        //                {
        //                    Title = "Selected data",
        //                    Values = values,
        //                    PointGeometry = null
        //                };
        //                //Adding series to chart
        //                MyChart.Series.Add(series);
        //                //Adding Y Axis to chart
        //                MyChart.AxisY.Add(new LiveCharts.Wpf.Axis
        //                {
        //                    Title = "Selected data values"
        //                });

        //                //Adding X Axis to chart
        //                MyChart.AxisX.Add(new LiveCharts.Wpf.Axis
        //                {
        //                    Title = "Date",
        //                    Labels = dateValues.Select(x => x.ToShortDateString()).ToList()
        //                });
        //            }
        //        }
        //    }
        //}

        //private void showDataButton_Click(object sender, RoutedEventArgs e)
        //{
        //    using (SqlConnection con = new SqlConnection(@"Server=LAPTOP-MDDJ1L5P\SQLEXPRESS;Database=LRDATABASE;Integrated Security=True"))
        //    {
        //        con.Open();
        //        string query = "";
        //        if (sugarCheckbox.IsChecked == true)
        //        {
        //            query = "SELECT sugar, dateS FROM Sugar";
        //        }
        //        else if (weightCheckbox.IsChecked == true)
        //        {
        //            query = "SELECT weight, dateP FROM Profil";
        //        }
        //        else if (activityCheckbox.IsChecked == true)
        //        {
        //            query = "SELECT activity, dateS FROM Sugar";
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please select one of the checkboxes.");
        //            return;
        //        }
                
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                var values = new ChartValues<double>();
        //                var dateValues = new ChartValues<DateTime>();
        //                int dateSIndex = reader.GetOrdinal("dateS");
        //               // int datePIndex = reader.GetOrdinal("dateP");


        //                while (reader.Read())
        //                {
        //                    values.Add(Convert.ToDouble(reader.GetValue(0)));
        //                    dateValues.Add(reader.GetDateTime(dateSIndex));
        //                }
        //                var series = new LineSeries
        //                {
        //                    Title = "Selected data",
        //                    Values = values,
        //                    PointGeometry = null
        //                };
        //                MyChart.Series.Clear();
        //                MyChart.Series.Add(series);
        //                //Adding series to chart
        //                MyChart.Series.Add(series);
        //                //Adding Y Axis to chart
        //                MyChart.AxisY.Add(new LiveCharts.Wpf.Axis
        //                {
        //                    Title = "Selected data values"
        //                });

        //                //Adding X Axis to chart
        //                MyChart.AxisX.Add(new LiveCharts.Wpf.Axis
        //                {
        //                    Title = "Date",
        //                    Labels = dateValues.Select(x => x.ToShortDateString()).ToList()
        //                });
                        
        //            }
        //        }
        //    }
        //}



        //private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        //{
        //    MyChart.Width = ActualWidth;
        //    MyChart.Height = ActualHeight;
        //}

        //public class MyViewModel
        // {
        //     public List<LineSeries> LineSeriesCollection { get; set; }
        //     public List<string> XValues { get; set; }

        //     private List<DataPoint> GetDataFromDatabase()
        //     {
        //         var dataPoints = new List<DataPoint>();

        //         using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LRDATABASE"].ConnectionString))
        //         {
        //             connection.Open();

        //             using (SqlCommand command = new SqlCommand("SELECT * FROM MyTable", connection))
        //             using (SqlDataReader reader = command.ExecuteReader())
        //             {
        //                 while (reader.Read())
        //                 {
        //                     // Create a DataPoint object and add it to the list
        //                     var dataPoint = new DataPoint
        //                     {
        //                         Name = reader["Name"].ToString(),
        //                         Label = reader["Label"].ToString(),
        //                         Value = (double)reader["Value"],
        //                     };

        //                     dataPoints.Add(dataPoint);
        //                 }
        //             }
        //         }

        //         return dataPoints;
        //     }

        //     public MyViewModel()
        //     {
        //         // Retrieve data from the database and store it in a list of DataPoint objects
        //         var dataPoints = GetDataFromDatabase();

        //         // Initialize the LineSeriesCollection and XValues properties
        //         LineSeriesCollection = new List<LineSeries>();
        //         XValues = new List<string>();

        //         // Create a LineSeries for each data series in the chart
        //         foreach (var series in dataPoints)
        //         {
        //             var lineSeries = new LineSeries
        //             {
        //                 Title = series.Name,
        //                 // Use the Value property of the DataPoint object as the y-value of the chart point
        //                 Values = new ChartValues<double> { series.Value },
        //             };

        //             LineSeriesCollection.Add(lineSeries);
        //         }

        //         // Set the XValues property to the labels for the x-axis of the chart
        //         XValues = dataPoints.Select(s => s.Label).ToList();
        //     }
        // } 

        /*public Day()
        {
            InitializeComponent();

            // Ustaw źródło danych dla kontrolki wykresu
            Chart.DataContext = new MyViewModel();
        }

        private void Day_back_button_Click(object sender, RoutedEventArgs e)
        {
            MenuApp ma1 = new MenuApp();
            this.Close();
            ma1.Show();
        }
    }

    public class DataPoint
    {
        public string Name { get; set; }
        public string Label { get; set; }
        public double Value { get; set; }
    }

    public class MyViewModel
    {
        public List<LineSeries> LineSeriesCollection { get; set; }
        public List<string> XValues { get; set; }

        private List<DataPoint> GetDataFromDatabase()
        {
            var dataPoints = new List<DataPoint>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LRDATABASE"].ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM MyTable", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Create a DataPoint object and add it to the list
                        var dataPoint = new DataPoint
                        {
                            Name = reader["Name"].ToString(),
                            Label = reader["Label"].ToString(),
                            Value = (double)reader["Value"],
                        };

                        dataPoints.Add(dataPoint);
                    }
                }
            }

            return dataPoints;
        }

        public MyViewModel()
        {
            // Retrieve data from the database and store it in a list of DataPoint objects
            var dataPoints = GetDataFromDatabase();

            // Initialize the LineSeriesCollection and XValues properties
            LineSeriesCollection = new List<LineSeries>();
            XValues = new List<string>();

            // Create a LineSeries for each data series in the chart
            foreach (var series in dataPoints)
            {
                var lineSeries = new LineSeries
                {
                    Title = series.Name,
                    // Use the Value property of the DataPoint object as the y-value of the chart point
                    Values = new ChartValues<double> { series.Value },
                };

                LineSeriesCollection.Add(lineSeries);
            }

            // Set the XValues property to the labels for the x-axis of the chart
            XValues = dataPoints.Select(s => s.Label).ToList();
        }*/
    }

    } 


