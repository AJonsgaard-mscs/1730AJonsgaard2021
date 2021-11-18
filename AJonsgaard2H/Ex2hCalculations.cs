using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            DateTime currentdate;
            currentdate = DateTime.Parse(strDateA);
            DateTime duedate;
            duedate = DateTime.Parse(strDateB);
            string days;

            try
            {
                TimeSpan timetilldue = duedate.Subtract(currentdate);
                int daystilldue = timetilldue.Days;
                days = Convert.ToString(timetilldue) + "days";
                result = days.ToString();
            }
            catch { }

            return result;
        }
        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid Input";
            DateTime dateA = DateTime.Parse(strDateA);
            DateTime dateB = DateTime.Parse(strDateB);
            TimeSpan daystilldue;

            if (dateA > dateB)
            {
                daystilldue = dateB - dateA;
                result = (daystilldue + "Days Past Due");
                if (dateB > dateA)
                return "On Time";

            }
            return result;
            
        }
    }
}
      