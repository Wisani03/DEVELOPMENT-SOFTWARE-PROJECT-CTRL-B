using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVELOPMENT_SOFTWARE_PROJECT_CTRL_B
{
    public partial class dashboardform : Form
    {
        public dashboardform()
        {
            InitializeComponent();

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0, 10),               // first point of first line
                         new ObservablePoint(4, 7),               // 2nd point
                          new ObservablePoint(5, 3),
                           new ObservablePoint(7, 16),
                           new ObservablePoint(10, 8),

                    },
                    PointGeometrySize = 10
                    
                },
                 new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0, 2),               // first point of 2nd line
                         new ObservablePoint(2, 5),               // 2nd point
                          new ObservablePoint(3, 6),
                           new ObservablePoint(6, 8),
                           new ObservablePoint(10, 5),


                    },
                    PointGeometrySize = 15

                },
                  new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    { new ObservablePoint(0, 4),               // first point of 3rd line
                         new ObservablePoint(5, 5),               // 2nd point
                          new ObservablePoint(7, 7),
                           new ObservablePoint(9, 10),
                           new ObservablePoint(10, 9),

                    },
                    PointGeometrySize = 10

                }
            };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dashboardform_Load(object sender, EventArgs e)
        {


            // Step 1: Create the data table
            DataTable table = new DataTable();

            table.Columns.Add("Row", typeof(int));               // Column for row number
            table.Columns.Add("Subject", typeof(string));
            table.Columns.Add("Assignment", typeof(string));

            // Step 2: Add rows without due dates
            table.Rows.Add(1, "Mathematics", "Euclidean Geometry");
            table.Rows.Add(2, "English", "Oral Speech");
            table.Rows.Add(3, "Physics", "Lab Report");
            table.Rows.Add(4, "Life Sciences", "DNA Research");
            table.Rows.Add(5, "Geography", "Tropical Cyclone Research");

            // Step 3: Bind the data to your DataGridView
            dataGridView1.DataSource = table;

            // Optional: Auto-size columns for better layout
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }

    }

