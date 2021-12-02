using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJonsgaard3A
{
    public class Ex3aLoops
    {
        //    public static string Calc0()
        //    {
        //        int i = 1, sum = 0;
        //        while (i < 5)
        //        {
        //            sum += i;
        //            i++;
        //        }
        //        return sum.ToString();
        //    }
        public static string Calc0(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInerestRate = Double.Parse(strMonthlyInterestRate);
                int i = 1;
                while (i <= months)
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInerestRate);
                    i++;
                }
            }
            catch
            {
                return "Invalid Input";
            }
            return futureValue.ToString("n2");
        }
        public static string Calc1(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInerestRate = Double.Parse(strMonthlyInterestRate);
                int i = 1;
                do
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInerestRate);
                    i++;
                }
                while (i <= months);
            }
            catch
            {
                return "Invalid Input";
            }
            return futureValue.ToString("n2");
        }
        public static string Calc2(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInerestRate = Double.Parse(strMonthlyInterestRate);
                for (int i = 1; i <= months; i++)
                { 
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInerestRate);
                }
            }
            catch
            {
                return "Invalid Input";
            }
            return futureValue.ToString("n2");
        }
        public static string Calc3(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int Start = Int32.Parse(strStart);
                int End = Int32.Parse(strEnd);
                int Increment = Int32.Parse(strIncrement);
                int i = Start;
                string Total = "";
                if (Increment <= 0) throw new Exception();
                while (i < End)
                {
                    Total += i + " ";
                    i += Increment;
                    result = Total;
                }
            }
            catch 
            { return "Invalid Input"; }
            return result;
        }

        public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int Start = Int32.Parse(strStart);
                int End = Int32.Parse(strEnd);
                int Increment = Int32.Parse(strIncrement);
                int i = Start;
                string Total = "";
                if (Increment <= 0) throw new Exception();
                do
                {
                    Total += i + " ";
                    i += Increment;
                    result = Total;
                }
                while (i < End);
            }
            catch
            { return "Invalid Input"; }
            return result;
        }

        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int Start = Int32.Parse(strStart);
                int End = Int32.Parse(strEnd);
                int Increment = Int32.Parse(strIncrement);
                string Total = "";
                if (Increment <= 0) throw new Exception();
                for (int i = Start; i <= End; i += Increment)
                    Total += i + " ";
                return Total;
            }
            catch
            { result = "Invalid Input"; }
            return result;
        }

        public static string Calc6(string strNumbers, string strCount)
        {
            string result = "0";
            int startIndex = 0;
            int Total = 0;
            try
            {
            int Count = Int32.Parse(strCount);
                while (Count > 0)
                {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumber);
                    Total += number;
                    startIndex = endIndex;
                    startIndex++;
                    Count = Count - 1;
                    result = Total.ToString();
                }
            }
            catch
            {
                result = "Invalid Input";
            }
            return result;
        }

        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "0";
            int startIndex = 0;
            int Total = 0;
            try
            {
                int Count = Int32.Parse(strCount);
                do
                {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumber);
                    Total += number;
                    startIndex = endIndex + 1;
                    Count = Count - 1;
                    result = Total.ToString();
                }
                while (Count > 0);
            }
            catch
            {
                result = "Invalid Input";
            }
            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "0";
            int startIndex = 0;
            int Total = 0;
            try
            {
                int Count = Int32.Parse(strCount);
                string strNumber = "";
                for (int endIndex = 0; Count > 0;)
                {
                    endIndex = strNumbers.IndexOf(' ', startIndex);
                    strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumber);
                    Total += number;
                    startIndex = endIndex + 1;
                    Count = Count - 1;
                    result = Total.ToString();
                }
            }
            catch
            {
                result = "Invalid Input";
            }
            return result;
        }
    }
}
