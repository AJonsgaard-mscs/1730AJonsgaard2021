using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJonsgaard3B
{
    public class Ex3BCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal DiscountPercent = 0m;
            if (subtotal >= 500m)
                DiscountPercent = 0.2m;
            else
                DiscountPercent = 0.1m;
            return DiscountPercent;
        }
        public static decimal CalculateFutureValue(decimal MonthlyInvestment, decimal MonthlyInterestRate, int Months)
        {
            decimal futureValue = 0m;

            for (int i = 1; i <= Months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + MonthlyInterestRate);
            }
            return futureValue;
        }
        public static decimal CalculateFutureValue(decimal MonthlyInvestment, decimal MonthlyInterestRate, int Months, ref decimal FutureValue)
        {
            for (int i = 1; i <= Months; i++)
            {
                FutureValue = (FutureValue + MonthlyInvestment) * (1 + MonthlyInterestRate);
            }
            return FutureValue;
        }
        public static double FahrenheitToCelsius(double Fahrenheit)
        {
            double Celsius = 0;
            string f = Fahrenheit.ToString();
            if (f != "")
            {
                Celsius = (Fahrenheit - 32) / 1.8;
            }
            return Celsius;
        }
        public static decimal GrossPay(decimal Hours, decimal Rate)
        {
            decimal Wage = 0m;
            decimal OTRate = 1.5m;

            if (Hours <= 40)
            {
                Wage = Hours * Rate;
            }
            if (Hours > 40)
            {
                decimal OtHours = Hours - 40;
                decimal straightpay = 40 * Rate;
                Wage = straightpay + (OtHours * (Rate * OTRate));
            }
            return Wage;
        }
        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;
            int startIndex = 0;
            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;

            }
            return total;
        }
        public static decimal GrossPaystr(string strNumbers, decimal Rate)
        {
            decimal totalHours = 0;
            decimal total = 0;
            int startIndex = 0;
            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = Decimal.Parse(strNumber);
                totalHours += number;
                startIndex = endIndex + 1;

            }
            total = totalHours * Rate;
            return total;
        }
    }
}
