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

namespace CourseWork
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            LoadData();
        }

        private void openPriceSetting_Click(object sender, EventArgs e)
        {
            PriceFrom pf = new PriceFrom();
            pf.ShowDialog();
        }

        private void visitorCheckIn_Click(object sender, EventArgs e)
        {
            VisitorCheckInForm vcf = new VisitorCheckInForm();
            vcf.ShowDialog();
        }

        private void openReports_Click(object sender, EventArgs e)
        {
            Reports re = new Reports();
            re.ShowDialog();
        }
        private void LoadData() {
            string data = Utility.ReadFromFile("visitor.txt");
            DateTime selectDate = DateTime.Now.Date;
            if (data != null && data != "")
            {
                List<Visitor> lstVisitor = JsonConvert.DeserializeObject<List<Visitor>>(data);
                var groupData = lstVisitor.Where(n => n.date.Date == selectDate)
                 .Select(n => new
                 {
                     Visitor_ID = n.ID,
                     Phone_Number=n.phoneNumber,
                     Age_Group=n.age,
                     Group_of =n.groupOf,
                     In_Time=n.inTime,
                     
                 }).ToList();
                this.dataGridView1.DataSource = groupData;
            }
        }

        private void visitorCheckOut_Click(object sender, EventArgs e)
        {
            VisitorCheckOutForm pf = new VisitorCheckOutForm();
            pf.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
