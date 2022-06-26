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
    public partial class VisitorCheckInForm : Form
    {
        public VisitorCheckInForm()
        {
            InitializeComponent();
            dataview();
        }
        private static Random random = new Random();
        private void submit_Click(object sender, EventArgs e)
        {
            Boolean isNull = checkNull();
            if (isNull)//Checking if all the Text Fileds are filled
            {
                //Generating ID for Visitor
                string id = RandomString(4);
                string read1 = Utility.ReadFromFile("visitor.txt");
                if (read1 != null && read1 != "")
                {
                    List<Visitor> lstVisitor = JsonConvert.DeserializeObject<List<Visitor>>(read1);
                    var value = lstVisitor
                               .Select(r => r.ID)
                               .Last().ToString();
                    Console.WriteLine(value);
                    String[] code = value.Split('_');
                    int number = int.Parse(code[1]);
                    number++;
                    id += "_" + number;
                    Console.WriteLine(id);
                }
                else
                {
                    id += "_" + 1;
                }
                //Getting values of visitor from form
                string name = nameTB.Text;
                string phoneNumber = phoneNumberTB.Text;
                string age = AgeCB.Text;
                var inTime = DateTime.Now.ToString("HH:mm:ss");
                DateTime date = DateTime.Now.Date;
                int groupOf = int.Parse(groupOfTB.Text);
                
                Visitor v;
                v = new Visitor();
                v.ID = id;
                v.name = name;
                v.phoneNumber = phoneNumber;
                v.age = age;
                v.inTime = inTime;
                v.date = date;
                v.groupOf = groupOf;

                string data = Utility.ReadFromFile("Visitor.txt");
                List<Visitor> lstPrice = new List<Visitor>();
                if (data != null && data != "")
                {
                    lstPrice = JsonConvert.DeserializeObject<List<Visitor>>(data);
                }
                lstPrice.Add(v);
                string str = JsonConvert.SerializeObject(lstPrice);
                Utility.WriteToText(str, "Visitor.txt");
                dataview();
                dataGridView1.Update();
                dataGridView1.Refresh();
                MessageBox.Show("Check In Successful\n" + "Your ID is " + id);
                clear();
            }
            else
            { 
                MessageBox.Show("Please Fill All The Fileds."); //Displaing message if textfield is empty or null
            }
        }

        private void clear() {
            AgeCB.SelectedIndex = -1;
            nameTB.Text = "";
            groupOfTB.Text = "";
            phoneNumberTB.Text = "";
        }
        //Function to show data in grid view
        private void dataview()
        {
            string data = Utility.ReadFromFile("visitor.txt");
            if (data != null && data != "")
            {
                List<Visitor> lstVisitor = JsonConvert.DeserializeObject<List<Visitor>>(data);
                this.dataGridView1.DataSource = lstVisitor;
            }
        }

        //function to check if textfields are empty or null
        private Boolean checkNull()
        {
            if (String.IsNullOrEmpty(nameTB.Text) || String.IsNullOrEmpty(phoneNumberTB.Text) || String.IsNullOrEmpty(AgeCB.Text) || String.IsNullOrEmpty(groupOfTB.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //function to generate random 4 letters
         public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void groupOfTB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(groupOfTB.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                groupOfTB.Text = groupOfTB.Text.Remove(groupOfTB.Text.Length - 1);
            }
        }

        private void phoneNumberTB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(phoneNumberTB.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                phoneNumberTB.Text = phoneNumberTB.Text.Remove(phoneNumberTB.Text.Length - 1);
            }
        }
    }
}
