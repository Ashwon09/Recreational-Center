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
    public partial class report1 : Form
    {
        public report1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
             
            }

        private void Submit_Click(object sender, EventArgs e)
        {
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
                        Count = n.Sum(n1=> n1.groupOf).ToString()
                    }).ToList();
                this.dataGridView1.DataSource = groupData;
            }
    }
    }
}
