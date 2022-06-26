using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseWork
{
    public partial class report2 : Form
    {
        private bool order = true;
        public report2()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {

            chart1.Series.Clear();
            chart1.Legends.Clear();
            string seriesname = "MySeriesName";
            chart1.Series.Add(seriesname);

            chart1.Legends.Add("MyLegend");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "Days";
            chart1.Legends[0].BorderColor = Color.Black;

            chart1.Series[seriesname].ChartType = SeriesChartType.Pie;

            DateTime date = dateTimePicker1.Value.Date; //get current datetime 
                                                        //get year from the date
            int year = date.Date.Year;
            //set the first day of the year
            DateTime firstDay = new DateTime(year, 1, 1);
            //get Day of the week 
            DayOfWeek day = date.DayOfWeek;
            CultureInfo cul = CultureInfo.CurrentCulture;
            //get no of week for the date
            int weekNo = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
            //get no of day
            int days = (weekNo - 1) * 7;
            DateTime dt1 = firstDay.AddDays(days);
            DayOfWeek dow = dt1.DayOfWeek;
            DateTime startDateOfWeek = dt1.AddDays(-(int)dow);
            DateTime endDateOfWeek = startDateOfWeek.AddDays(6);


            string data = Utility.ReadFromFile("visitor.txt");
            if (data != null && data != "")
            {
                List<Visitor> lstVisitor = JsonConvert.DeserializeObject<List<Visitor>>(data);
                var groupData = lstVisitor.Where(n => (n.date) >= startDateOfWeek && (n.date) <= endDateOfWeek).GroupBy(n => n.date)
                     .Select(n => new
                     {
                         Day = n.Key.ToString("dddd"),
                         Date = n.Key,
                         noOfVisitor = n.Sum(n1 => n1.groupOf),
                         Earning = n.Sum(n1 => n1.price)
                     }).ToList();
                this.dataGridView1.DataSource = groupData;

                foreach (var item in groupData)
                {
                    chart1.Series[seriesname].Points.AddXY(item.Day, item.Earning);
                }
                chart1.Series[seriesname].IsValueShownAsLabel = true;
            }
        }

        private void sortByEarning_Click(object sender, EventArgs e)
        {
            //getting data from datagridview
            List <weeklyReport> lstWeek= new List<weeklyReport>();
            foreach (DataGridViewRow Datarow in dataGridView1.Rows)
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null && Datarow.Cells[3].Value != null)
                {
                    weeklyReport day = new weeklyReport();
                    day.day = Datarow.Cells[0].Value.ToString();
                    day.date = DateTime.Parse(Datarow.Cells[1].Value.ToString());
                    day.noOfVisitor = int.Parse(Datarow.Cells[2].Value.ToString());
                    day.earning = int.Parse(Datarow.Cells[3].Value.ToString());
                    lstWeek.Add(day);
                }
            }

            lstWeek = bubbleSort(lstWeek);//sorting the list
            this.dataGridView1.DataSource = lstWeek;//displating sorted list in datagridview
        }

        //function to sort data by earning
        private List<weeklyReport> bubbleSort(List<weeklyReport> data) {
           weeklyReport temp = new weeklyReport();
            if (order)
            {
                for (int i = data.Count-1; i > 0; i--)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        if (data[j].earning < data[j + 1].earning)
                        {
                            temp = data[j];
                            data[j] = data[j + 1];
                            data[j + 1] = temp;
                        }
                    }
                }
                order = false;
            }
            else
            {
                for (int i = data.Count - 1; i > 0; i--)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        if (data[j].earning > data[j + 1].earning)
                        {
                            temp = data[j];
                            data[j] = data[j + 1];
                            data[j + 1] = temp;
                        }
                    }
                }
                order = true;
            }
            return data;
        }

        private void sortByVisitors_Click(object sender, EventArgs e)
        {
            //getting data from datagridview
            List<weeklyReport> lstWeek = new List<weeklyReport>();
            foreach (DataGridViewRow Datarow in dataGridView1.Rows)
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null && Datarow.Cells[3].Value != null)
                {
                    weeklyReport day = new weeklyReport();
                    day.day = Datarow.Cells[0].Value.ToString();
                    day.date = DateTime.Parse(Datarow.Cells[1].Value.ToString());
                    day.noOfVisitor = int.Parse(Datarow.Cells[2].Value.ToString());
                    day.earning = int.Parse(Datarow.Cells[3].Value.ToString());
                    lstWeek.Add(day);
                }
            }

            lstWeek = bubbleSortVisitors(lstWeek);//sorting the list
            this.dataGridView1.DataSource = lstWeek;//displating sorted list in datagridview
        }

        private List<weeklyReport> bubbleSortVisitors(List<weeklyReport> data)
        {
            weeklyReport temp = new weeklyReport();
            if (order)
            {
                for (int i = data.Count - 1; i > 0; i--)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        if (data[j].noOfVisitor < data[j + 1].noOfVisitor)
                        {
                            temp = data[j];
                            data[j] = data[j + 1];
                            data[j + 1] = temp;
                        }
                    }
                }
                order = false;
            }
            else
            {
                for (int i = data.Count - 1; i > 0; i--)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        if (data[j].noOfVisitor > data[j + 1].noOfVisitor)
                        {
                            temp = data[j];
                            data[j] = data[j + 1];
                            data[j + 1] = temp;
                        }
                    }
                }
                order = true;
            }
            return data;
        }
    }
}
