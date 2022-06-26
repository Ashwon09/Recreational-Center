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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void reportDailyButton_Click(object sender, EventArgs e)
        {
            report1 vcf = new report1();
            vcf.ShowDialog();
        }

        private void reportWeeklyButton_Click(object sender, EventArgs e)
        {
            report2 vcf = new report2();
            vcf.ShowDialog();
        }

        private void reportChartButton_Click(object sender, EventArgs e)
        {
            report3 vcf = new report3();
            vcf.ShowDialog();
        }
    }
}
