using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Utility
    {
        private static string _filePath ;
        public static string WriteToText(string data, string file)
        {
            _filePath = file;
            if (!File.Exists(_filePath))
            {
                using (File.Create(_filePath));
            }
            using (StreamWriter outputFile = new StreamWriter(_filePath))
            {
                outputFile.WriteLine(data);
            }
            return "success";
        }

        public static string ReadFromFile(string file)
        {
            _filePath = file;
            if (File.Exists(_filePath))
            {
                string Data = File.ReadAllText(_filePath);
                return Data;
            }
            return null;
        }

        public static void editVisitor(string id, string checkOut, int price, string duration)
        {
            List<Visitor> visitorList = new List<Visitor>();
            string data = ReadFromFile("Visitor.txt");
            if (data != null && data != "")
            {
                List<Visitor> lstVisitor = JsonConvert.DeserializeObject<List<Visitor>>(data);
                foreach (var visitor in lstVisitor) {
                    if (visitor.ID == id)
                    {
                        visitor.outTime = checkOut;
                        visitor.duration = duration;
                        visitor.price = price;
                        visitorList.Add(visitor);
                    }
                    else {
                        visitorList.Add(visitor);
                    }
                }   
            }
            string str = JsonConvert.SerializeObject(visitorList);
            Utility.WriteToText(str, "Visitor.txt");
        }

        public static void editPrice(Price price) {
            List<Price> priceList = new List<Price>();
            string data = ReadFromFile("price.txt");
            if (data != null && data != "")
            {
                List<Price> lstPrice = JsonConvert.DeserializeObject<List<Price>>(data);
                foreach (var p in lstPrice)
                {
                    if (p.Group == price.Group && p.Duration == price.Duration)
                    {
                        p.Group = price.Group;
                        p.Duration = price.Duration;
                        p.childWeekDays = price.childWeekDays;
                        p.childWeekEnds = price.childWeekEnds;
                        p.adultWeekDays = price.adultWeekDays;
                        p.adultWeekEnds = price.adultWeekEnds;
                        p.oldWeekDays = price.oldWeekDays;
                        p.oldWeekEnds = price.oldWeekEnds;

                        priceList.Add(p);
                    }
                    else
                    {
                        priceList.Add(p);
                    }
                }
            }
            string str = JsonConvert.SerializeObject(priceList);
            Utility.WriteToText(str, "price.txt");
        }
    }

}
