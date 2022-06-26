using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseWork
{
    public partial class report3 : Form
    {
        public report3()
        {
            InitializeComponent();
        }

  
        private void button1_Click(object sender, EventArgs e)
        {

            chart1.Series.Clear();
            chart1.Legends.Clear();

            chart1.Legends.Add("MyLegend");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "Age Groups";
            chart1.Legends[0].BorderColor = Color.Black;

            string seriesname = "MySeriesName";
            chart1.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chart1.Series[seriesname].ChartType = SeriesChartType.Pie;

            DateTime selectDate = dateTimePicker1.Value.Date;

            Console.WriteLine(selectDate);
            string data = Utility.ReadFromFile("visitor.txt");
            if (data != null && data != "")
            {
                List<Visitor> lstVisitor = JsonConvert.DeserializeObject<List<Visitor>>(data);
                var groupData = lstVisitor.Where(n => n.date.Date == selectDate).GroupBy(n => n.age)
                  .Select(n => new
                  {
                      age_Group = n.Key,
                      Earning = n.Sum(n1 => n1.price)
                  }).ToList();
                foreach (var item in groupData)
                {
                    chart1.Series[seriesname].Points.AddXY(item.age_Group, item.Earning);
                }
                chart1.Series[seriesname].IsValueShownAsLabel = true;
            }
        }
    }
}
