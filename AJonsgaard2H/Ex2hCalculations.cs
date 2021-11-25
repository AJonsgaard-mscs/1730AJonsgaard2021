using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace AJonsgaard2H
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid Input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;

        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid Input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }
            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid Input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();
            return result;
        }
        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid Input";

            try
            {
                DateTime currentdate;
                currentdate = DateTime.Parse(strDateA);
                DateTime duedate;
                duedate = DateTime.Parse(strDateB);
                string days;

                TimeSpan timetilldue = currentdate - duedate;
                int daystilldue = timetilldue.Days;
                days = daystilldue.ToString() + " Days";
                result = days.ToString();
            }
            catch { }

            return result;
        }
        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid Input";

            try
            {
                DateTime currentdate;
                currentdate = DateTime.Parse(strDateA);
                DateTime duedate;
                duedate = DateTime.Parse(strDateB);
                TimeSpan daystilldue;
                if (currentdate > duedate)
                {
                    daystilldue = currentdate - duedate;
                    int days = daystilldue.Days;
                    result = (days + " Days Past Due");
                }
                else if (duedate == currentdate)
                {
                    result = "On Time";
                }
                else if (duedate > currentdate)
                {
                    result = "On Time";
                }
                return result;
            }
            catch { }
            return result;
        }
        public static string StringCalc01(string s)
        {
            // Remove and Insert
            string result = "Invalid Input";
            string word = s;
            word = word.Trim();

            if (word != "" && s.Length != 0)
            {
                word = word.Remove(0, 1);
                word = word.Insert(0, "c");
                word = word.Insert(1, "r");
                result = word;
            }
            return result;
        }
        public static string StringCalc02(string s)
        {
            //Remove and Insert
            string result = "Invalid Input";
            string word = s;
            word = word.Trim();

            if (word.Length >= 2)
            {
                word = word.Remove(1, 1);
                word = word.Insert(1, "r");
                word = word.Insert(2, "i");
                word = word.Insert(3, "t");
                result = word;
            }
            return result;
        }
        public static string StringCalc03(string s)
        {
            //Substring and To Upper
            string word = s;
            word = word.Trim();
            if (word.Length >= 6)
            {
                string color = word.Substring(2, 4).ToUpper();
                return color;
            }
            return "Invalid Input";
        }
        public static string StringCalc04(string s)
        {
            //Pad Left
            string all = "";
            string word = s;
            word = word.Trim();
            char pad = '*';
            all = word.PadLeft(10, pad);
            return all;
        }
        public static string StringCalc05(string s)
        {
            //Replace
            s = s.Replace(" ", "");
            s = s.Replace("(", "");
            s = s.Replace(")", "");
            s = s.Replace("-", "");

            return s;
        }
        public static string StringCalc06(string s)
        {
            //Replace, Length and Insert
            string result = "Intalid Input";
            s = s.Replace(" ", "");
            s = s.Replace("(", "");
            s = s.Replace(")", "");
            s = s.Replace("-", "");
            int ls = s.Length;
            if (ls == 10)
            {
                s = s.Insert(3, ".");
                s = s.Insert(7, ".");
                return s;
            }
            if (ls == 7)
            {
                s = s.Insert(3, ".");
                return s;
            }
            return result;
        }
        public static string StringCalc07(string s)
        {
            //To Lowwer and Contains
            string result = "Not Found";
            s = s.ToLower();
            if (s.Contains("pioneer"))
            {
                result = "Found";
            }
            return result;
        }
        public static string StringCalc08(string s)
        {
            //IndexOf and Substring
            string address = s;
            address = address.Trim();
            if (address.IndexOf(",") >= 0)
            {
                int cityindex = address.IndexOf(",") + 1;
                string city = address.Substring(cityindex + 1);
                return city;
            }
            return "Invalid Input";
        }
        public static string StringCalc09(string s)
        {
            //LastIndexOf and Substring
            string address = s;
            address = address.Trim();
            if (address.LastIndexOf(" ") >= 0)
            {
                int zip = address.LastIndexOf(" ");
                string last = address.Substring(zip + 1);
                return last;
            }
            return "Invalid Input";
        }
        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder sb = new StringBuilder(100);
            sb.Append(s1 + ", ");
            sb.Append(s2 + ", ");
            sb.Append(s3);
            return sb.ToString();
        }
    }
}
      