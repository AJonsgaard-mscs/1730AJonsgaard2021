using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJonsgaard2F_if_if_else
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            decimal subtotal = 0m;
            decimal discountpercent = 0m;
            // #1: if
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountpercent = 0.2m;
            return discountpercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            decimal subtotal = 0m;
            decimal discountpercent = 0m;

            // #2 if {block}
            subtotal = Decimal.Parse(input);
            discountpercent = 0m;
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountpercent = 0.2m;
                status = "Bulk rate: " + discountpercent.ToString("n2");
            }
            return status;
        }

        public static string Calc03(string input)
        {
            decimal subtotal = 0m;
            decimal discountpercent = 0m;

            // #3 if else
            subtotal = Decimal.Parse(input);
            discountpercent = 0m;
            if (subtotal >= 100m)
                discountpercent = 0.2m;
            else
                discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            decimal subtotal = 0m;
            decimal discountpercent = 0m;

            //#4 if else if
            subtotal = Decimal.Parse(input);
            discountpercent = 0m;
            if (subtotal >= 100m && subtotal < 200m)
                discountpercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300m)
                discountpercent = 0.3m;
            else if (subtotal >= 300m)
                discountpercent = 0.4m;
            else
                discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            decimal subtotal = 0m;
            decimal discountpercent = 0m;

            //#5 Better range test
            subtotal = Decimal.Parse(input);
            discountpercent = 0m;
            if (subtotal >= 300m)
                discountpercent = 0.4m;
            else if (subtotal >= 200m)
                discountpercent = 0.3m;
            else if (subtotal >= 100m)
                discountpercent = 0.2m;
            else
                discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            decimal subtotal = 0m;
            decimal discountpercent = 0m;

            //#6 Nested if
            subtotal = Decimal.Parse(inputA);
            string customerType = inputB;
            discountpercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountpercent = 0.2m;
                else discountpercent = 0.1m;
            }
            else       // costumerType isn't "R"
                discountpercent = 0.4m;
            return discountpercent.ToString("n2");

        }
        public static string Calc07(string input)
        {

            //#7 Validate input: non-empty string
            decimal ethereum = 0m;            
            if (input != "")
            {
                decimal dollars = Decimal.Parse(input);
                ethereum = dollars * 200m;
                return ethereum.ToString("n2");
            }
            return "Invalid Input";
        }
        public static string Calc08(string inputA, string inputB)
        {
            
            decimal price = 0m;
            decimal quantity = 0m;
            decimal shipping = 0m;
            decimal total = 0m;
            // #8 Validate input, calculate quantity * price, shipping

            if (inputA != "" && inputB != "")
            {
                price = Decimal.Parse(inputA);
                quantity = Decimal.Parse(inputB);
                shipping = price * quantity;
                if (shipping < 50)
                    total = shipping + 5;
                else if (shipping >= 50)
                    total = shipping;
                return total.ToString("n2");
            }
            return "Invalid Input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            if (inputA != "" && inputB != "")
            {
                decimal premonth = Decimal.Parse(inputA);
                decimal curmonth = Decimal.Parse(inputB);
                if (premonth < curmonth)
                {
                    decimal hours = 0m;
                    hours = curmonth - premonth;
                    decimal rate = .1m;
                    decimal total = 0;
                    if (curmonth > premonth)
                        total = hours * rate;
                    return total.ToString("n2");
                }
            }
            return "Invalid Input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
           
            decimal total = 0m;
            if (inputA != "" && inputB != "")
            {
                decimal first = Decimal.Parse(inputA);
                decimal second = Decimal.Parse(inputB);
                if (first != 0 && second != 0)
                {
                    if (first <= second)
                        total = second / first;
                    else if (first > second)
                        total = first / second;
                    return total.ToString("n2");
                }
            }
            return "Invalid Input";
            
        }
    }
}
