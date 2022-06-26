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
    public partial class VisitorCheckOutForm : Form
    {
        public VisitorCheckOutForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss"); ;
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(visitorIDTB.Text))
            {
                MessageBox.Show("Visitor ID field is empty");
            }
            else
            {
                string data = Utility.ReadFromFile("visitor.txt");
                if (data != null && data != "")
                {
                    List<Visitor> lstVisitor = JsonConvert.DeserializeObject<List<Visitor>>(data);
                    bool value = lstVisitor.Any(cus => cus.ID == visitorIDTB.Text);
                    if (value)
                    {
                        var groupData = lstVisitor.Where(n => n.ID == visitorIDTB.Text)
                          .Select(n => new
                          {
                              In_Time = n.inTime.ToString(),
                          }).ToList();

                        foreach (var v in groupData)
                        {
                            checkInLabel.Text = v.In_Time;
                        }
                    }
                    else
                    {
                        checkInLabel.Text = "";
                        MessageBox.Show("Visitor ID does not exists");
                    }
                }
            }
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            string duration = durationCB.Text;
            string id = visitorIDTB.Text;
            string checkOut = DateTime.Now.ToString("HH:mm:ss");
            string data = Utility.ReadFromFile("visitor.txt");
            if (data != null && data != "")
            {
                List<Visitor> lstVisitor = JsonConvert.DeserializeObject<List<Visitor>>(data);
                bool value = lstVisitor.Any(cus => cus.ID == id);//check if visitor ID exists returns true if exists

                if (value)
                {
                    var groupData = lstVisitor.Where(n => n.ID == id)
                         .Select(n => new
                         {
                             group_Of = n.groupOf,
                             age = n.age,
                             day = n.date.ToString("dddd"),
                         }).First();
                    string group = "";
                    // calculating which group visitor belongs to 
                    if (groupData.group_Of >= 1 && groupData.group_Of <= 4)
                    {
                        group = "1-4";
                    }
                    else if (groupData.group_Of >= 5 && groupData.group_Of <= 9)
                    {
                        group = "5-9";
                    }
                    else if (groupData.group_Of >= 10 && groupData.group_Of <= 19)
                    {
                        group = "10-19";
                    }
                    else
                    {
                        group = "20 and Above";
                    }

                    int price;
                    string prices = Utility.ReadFromFile("price.txt");
                    if (prices != null && prices != "")
                    {
                        List<Price> lstPrice = JsonConvert.DeserializeObject<List<Price>>(prices);
                        bool isPrice = lstPrice.Any(cus => cus.Duration == duration && cus.Group == group);// check if price exists for the duration and group returns true if found
                        if (isPrice)
                        {
                            //finding price per person for visitor according to age group, duration and weekdays or weekends 
                            if (groupData.age == "3-15")
                            {
                                var priceDate = lstPrice.Where(n => n.Duration == duration && n.Group == group)
                             .Select(n => new
                             {
                                 WeekDays = n.childWeekDays,
                                 WeekEnds = n.childWeekEnds,
                             }).First();
                                if (groupData.day == "Saturday")
                                {
                                    price = priceDate.WeekEnds;
                                }
                                else
                                {
                                    price = priceDate.WeekDays;
                                }
                            }
                            else if (groupData.age == "16-59")
                            {
                                var priceDate = lstPrice.Where(n => n.Duration == duration && n.Group == group)
                             .Select(n => new
                             {
                                 WeekDays = n.adultWeekDays,
                                 WeekEnds = n.adultWeekEnds,
                             }).First();
                                if (groupData.day == "Saturday")
                                {
                                    price = priceDate.WeekEnds;
                                }
                                else
                                {
                                    price = priceDate.WeekDays;
                                }
                            }
                            else
                            {
                                var priceDate = lstPrice.Where(n => n.Duration == duration && n.Group == group)
                             .Select(n => new
                             {
                                 WeekDays = n.oldWeekDays,
                                 WeekEnds = n.oldWeekEnds,
                             }).First();
                                if (groupData.day == "Saturday")
                                {
                                    price = priceDate.WeekEnds;
                                }
                                else
                                {
                                    price = priceDate.WeekDays;
                                }
                            }
                            //calculating total price for the visitor
                            price = price * groupData.group_Of;
                            MessageBox.Show("Your total Price is " + price);
                            Utility.editVisitor(id, checkOut, price, duration);
                        }
                        else
                        {
                            //message if Price is not found 
                            MessageBox.Show("Price is not set for following duration and group");
                        }
                    }
                }
                else
                {
                    //message if visitor ID is not found
                    MessageBox.Show("Selected ID not Found");
                }
            }

        }
    }
}

