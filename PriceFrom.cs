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
    public partial class PriceFrom : Form
    {
        public PriceFrom()
        {
            InitializeComponent();
            dataview();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Boolean isNull = checkNull(); 

            if (isNull)//Checking if all the Text Fileds are filled
            {        
                //Getting values from Form to Store in text file
                string Group = GroupCB.Text;
                string Duration = DurationCB.Text;
                int childWeekDays = int.Parse(childWeekDaysTB.Text);
                int childWeekEnds = int.Parse(childWeekEndsTB.Text);
                int adultWeekDays = int.Parse(adultWeekDaysTB.Text);
                int adultWeekEnds = int.Parse(adultWeekEndsTB.Text);
                int oldWeekDays = int.Parse(oldWeekDaysTB.Text);
                int oldWeekEnds = int.Parse(oldWeekEndsTB.Text);

                Price s;
                s = new Price();
                s.Group = Group;
                s.Duration = Duration;
                s.childWeekDays = childWeekDays;
                s.childWeekEnds = childWeekEnds;
                s.adultWeekDays = adultWeekDays;
                s.adultWeekEnds = adultWeekEnds;
                s.oldWeekDays = oldWeekDays;
                s.oldWeekEnds = oldWeekEnds;

                string data = Utility.ReadFromFile("price.txt");
                List<Price> lstPrice = new List<Price>();
                if (data != null && data != "")
                {
                    lstPrice = JsonConvert.DeserializeObject<List<Price>>(data);
                }

                //Checking for duplicate entry
                bool duplicate = lstPrice.Any(cus => cus.Group == Group && cus.Duration == Duration);
                if (!duplicate) // add if value is not duplicate
                {
                    lstPrice.Add(s);
                    string str = JsonConvert.SerializeObject(lstPrice);
                    Utility.WriteToText(str, "price.txt");
                    dataview();
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                    MessageBox.Show("Record Added");
                }
                else{//Give Message for duplicate entry
                    MessageBox.Show("Duplicate Entry");
                }
            }
            else {//Give Message if all the fields are not filled
                MessageBox.Show("Please Fill All The Fileds.");
            }
          
        }

        private void update_Click(object sender, EventArgs e)
        {
            Boolean isNull = checkNull();

            if (isNull)//Checking if all the Text Fileds are filled
            {
                //Getting values from Form to Store in text file
                string Group = GroupCB.Text;
                string Duration = DurationCB.Text;
                int childWeekDays = int.Parse(childWeekDaysTB.Text);
                int childWeekEnds = int.Parse(childWeekEndsTB.Text);
                int adultWeekDays = int.Parse(adultWeekDaysTB.Text);
                int adultWeekEnds = int.Parse(adultWeekEndsTB.Text);
                int oldWeekDays = int.Parse(oldWeekDaysTB.Text);
                int oldWeekEnds = int.Parse(oldWeekEndsTB.Text);

                Price s;
                s = new Price();
                s.Group = Group;
                s.Duration = Duration;
                s.childWeekDays = childWeekDays;
                s.childWeekEnds = childWeekEnds;
                s.adultWeekDays = adultWeekDays;
                s.adultWeekEnds = adultWeekEnds;
                s.oldWeekDays = oldWeekDays;
                s.oldWeekEnds = oldWeekEnds;

                string data = Utility.ReadFromFile("price.txt");
                List<Price> lstPrice = new List<Price>();
                if (data != null && data != "")
                {
                    lstPrice = JsonConvert.DeserializeObject<List<Price>>(data);
                }
                //Checking for duplicate entry
                bool duplicate = lstPrice.Any(cus => cus.Group == Group && cus.Duration == Duration);
                if (!duplicate) // add if value is not duplicate
                {
                    MessageBox.Show("Value Not Found");
                }
                else
                {//Give Message for duplicate entry
                    Utility.editPrice(s);
                    dataview();
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                    MessageBox.Show("Prices are updated");
                }
            }
            else
            {//Give Message if all the fields are not filled
                MessageBox.Show("Please Fill All The Fileds.");
            }

        }

        //Function to check if TextField is Empty or Null
        private Boolean checkNull() 
        {
            if (String.IsNullOrEmpty(GroupCB.Text) || String.IsNullOrEmpty(DurationCB.Text) || String.IsNullOrEmpty(childWeekDaysTB.Text) || String.IsNullOrEmpty(childWeekEndsTB.Text) || String.IsNullOrEmpty(adultWeekDaysTB.Text) || String.IsNullOrEmpty(adultWeekEndsTB.Text) || String.IsNullOrEmpty(oldWeekDaysTB.Text) || String.IsNullOrEmpty(oldWeekEndsTB.Text))
            {
                return false;

            }
            else {
                return true;
            }
            
        }

        //Function to display the data in grid view
        private void dataview()
        {
            string data = Utility.ReadFromFile("price.txt");
            if (data != null && data != "")
            {
                List<Price> lstPrice = JsonConvert.DeserializeObject<List<Price>>(data);
                this.dataGridView1.DataSource = lstPrice;
            }
        }

        private void childWeekDaysTB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(childWeekDaysTB.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                childWeekDaysTB.Text = childWeekDaysTB.Text.Remove(childWeekDaysTB.Text.Length - 1);
            }
        }

        private void childWeekEndsTB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(childWeekEndsTB.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                childWeekEndsTB.Text = childWeekEndsTB.Text.Remove(childWeekEndsTB.Text.Length - 1);
            }
        }

        private void adultWeekDaysTB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(adultWeekDaysTB.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                adultWeekDaysTB.Text = adultWeekDaysTB.Text.Remove(adultWeekDaysTB.Text.Length - 1);
            }
        }

        private void adultWeekEndsTB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(adultWeekEndsTB.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                adultWeekEndsTB.Text = adultWeekEndsTB.Text.Remove(adultWeekEndsTB.Text.Length - 1);
            }
        }

        private void oldWeekDaysTB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(oldWeekDaysTB.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                oldWeekDaysTB.Text = oldWeekDaysTB.Text.Remove(oldWeekDaysTB.Text.Length - 1);
            }
        }

        private void oldWeekEndsTB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(oldWeekEndsTB.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                oldWeekEndsTB.Text = oldWeekEndsTB.Text.Remove(oldWeekEndsTB.Text.Length - 1);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
             GroupCB.SelectedIndex = -1;
             DurationCB.SelectedIndex = -1;
             childWeekDaysTB.Text = "";
             childWeekEndsTB.Text = "";
             adultWeekDaysTB.Text = "";
             adultWeekEndsTB.Text = "";
             oldWeekDaysTB.Text = "";
             oldWeekEndsTB.Text = "";
        }

        
    }
}
