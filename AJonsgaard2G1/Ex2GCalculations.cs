using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJonsgaard2G1
{
    public class Ex2GCalculations
    {
        public static string Switch01(string customertype)
        {
            // 1a) 'Switch' with no default
            decimal discountpercent = -1m;

            switch (customertype)
            {
                case "R":
                    discountpercent = .1m;
                    break;
                case "C":
                    discountpercent = .2m;
                    break;
            }
            return discountpercent.ToString("0.0");
        }
        public static string If01(string customertype)
        {
            // 1b) Separate 'if' statements
            decimal discountpercent = -1m;

            if (customertype == "R")
                discountpercent = .1m;
            if (customertype == "C")
                discountpercent = .2m;
            return discountpercent.ToString("0.0");
        }
        public static string ElseIf01(string customertype)
        {
            // 1c) if else-if
            decimal discountpercent = -1m;

            if (customertype == "R")
                discountpercent = .1m;
            else if (customertype == "C")
                discountpercent = .2m;
            return discountpercent.ToString("0.0");
        }
        public static string NestedIf01(string customertype)
        {
            // 1d) Nested if-else
            decimal discountpercent = -1m;

            if (customertype == "R")
            {
                discountpercent = .1m;
            }
            else 
            {
                if (customertype == "C")
                {
                    discountpercent = .2m;
                }
            }
            return discountpercent.ToString("0.0");
        }
        public static string SwitchDefault01(string customertype)
        {
            // 1e) 'Switch' with default
            decimal discountpercent = -1m;

            switch (customertype)
            {
                case "R":
                    discountpercent = .1m;
                    break;
                case "C":
                    discountpercent = .2m;
                    break;
                default:
                    discountpercent = .0m;
                    break;
            }
            return discountpercent.ToString("0.0");
        }
        public static string IfDefault01(string customertype)
        {
            // 1f) Separate 'if' statements w/default
            decimal discountpercent = -1m;

            if (customertype == "R")
                discountpercent = .1m;
            if (customertype == "C")
                discountpercent = .2m;
            if (customertype != "R" && customertype != "C")
                discountpercent = .0m;
            return discountpercent.ToString("0.0");
        }
        public static string ElseIfDefault01(string customertype)
        {
            // 1g) if else-if w/default
            decimal discountpercent = -1m;

            if (customertype == "R")
                discountpercent = .1m;
            else if (customertype == "C")
                discountpercent = .2m;
            else if (customertype != "R" && customertype != "C")
                discountpercent = .0m;
            return discountpercent.ToString("0.0");
        }
        public static string NestedIfDefault01(string customertype)
        {
            // 1h) Nested if-else w/default
            decimal discountpercent = -1m;

            if (customertype == "R")
            {
                discountpercent = .1m;
            }
            else
            {
                if (customertype == "C")
                {
                    discountpercent = .2m;
                }
                else
                    discountpercent = .0m;
            }
            
            return discountpercent.ToString("0.0");
        }
        public static string Switch02(string customerType)
        {
            // 2a) 'Switch' with no default
            decimal discountpercent = -1m;
            switch (customerType)
            {
                case "R":
                case "C":
                    discountpercent = .2m;
                    break;
                case "T":
                    discountpercent = .4m;
                    break;
            }
            return discountpercent.ToString("0.0");
        }
        public static string If02(string customerType)
        {
            // 2b) Seperate 'if' statments
            decimal discountpercent = -1m;

            if (customerType == "R" || customerType == "C")
                discountpercent = .2m;
            if (customerType == "T")
                discountpercent = .4m;

            return discountpercent.ToString("0.0");
        }
        public static string ElseIf02(string customerType)
        {
            // 2c) if elseif
            decimal discountpercent = -1m;

            if (customerType == "R" || customerType == "C")
                discountpercent = .2m;
            else if (customerType == "T")
                discountpercent = .4m;
            return discountpercent.ToString("0.0");
        }
        public static string NestedIfElse02(string customerType)
        {
            // 2d) Nested if-else
            decimal discountpercent = -1m;

            if (customerType == "R" || customerType == "C")
            {
                discountpercent = .2m;
            }
            else
            {
                if (customerType == "T")
                {
                    discountpercent = .4m;
                }
            }
            return discountpercent.ToString("0.0");
        }
    }
}
