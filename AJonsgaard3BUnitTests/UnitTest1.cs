using AJonsgaard3B;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AJonsgaard3BUnitTests
{
    [TestClass]
    public class Ex3BUnitTest
    {
        [TestMethod]
        public void GetDiscountPercent_Low()
        {
            Assert.AreEqual(0.1m, Ex3BCalculations.GetDiscountPercent(499m));
        }
        [TestMethod]
        public void GetDiscountPercent_High()
        {
            Assert.AreEqual(0.2m, Ex3BCalculations.GetDiscountPercent(500m));
        }
        [TestMethod]
        public void GetDiscountPercent_Out_Low()
        {
            decimal discountPercent = 0m;
            Ex3BCalculations.GetDiscountPercent(499m, out discountPercent);
            Assert.AreEqual(0.1m, discountPercent);
        }
        [TestMethod]
        public void GetDiscountPercent_Out_High()
        {
            decimal discountPercent = 0m;
            Ex3BCalculations.GetDiscountPercent(500m, out discountPercent);
            Assert.AreEqual(0.2m, discountPercent);
        }
        [TestMethod]
        public void CalcFutureValue_12Mo100US()
        {
            Assert.AreEqual(1231.66m,
                Decimal.Round(Ex3BCalculations.CalculateFutureValue(100m, 0.004m, 12), 2));
        }
        [TestMethod]
        public void CalcFutureValue_120Mo20US()
        {
            Assert.AreEqual(2892.37m,
                Decimal.Round(Ex3BCalculations.CalculateFutureValue(20m, 0.003m, 120), 2));
        }
        [TestMethod]
        public void CalcFutureValue_Ref_12Mo100US()
        {
            decimal futureValue = 0m;
            Ex3BCalculations.CalculateFutureValue(100m, 0.004m, 12, ref futureValue);
            Assert.AreEqual(1231.66m, Decimal.Round(futureValue, 2));
        }
        [TestMethod]
        public void CalcFutureValue_Ref_120Mo20US()
        {
            decimal futureValue = 0m;
            Ex3BCalculations.CalculateFutureValue(20m, 0.003m, 120, ref futureValue);
            Assert.AreEqual(2892.37m, Decimal.Round(futureValue, 2));
        }
        [TestMethod]
        public void FahrenheitToCelsius212()
        {
            Assert.AreEqual(100.0,
                Math.Round(Ex3BCalculations.FahrenheitToCelsius(212.0), 1));
        }
        [TestMethod]
        public void FahrenheitToCelsius32()
        {
            Assert.AreEqual(0.0,
                Math.Round(Ex3BCalculations.FahrenheitToCelsius(32.0), 1));
        }
        [TestMethod]
        public void CelsiusToFahrenheit0()
        {
            double fahrenheit = 0.0;
            Ex3BCalculations.CelsiusToFahrenheit(0, out fahrenheit);
            Assert.AreEqual(32.0, Math.Round(fahrenheit, 1));
        }
        [TestMethod]
        public void CelsiusToFahrenheit100()
        {
            double fahrenheit = 0.0;
            Ex3BCalculations.CelsiusToFahrenheit(100, out fahrenheit);
            Assert.AreEqual(212.0, Math.Round(fahrenheit, 1));
        }
        [TestMethod]
        public void GrossPay_40_10()
        {
            Assert.AreEqual(400m,
                Decimal.Round(Ex3BCalculations.GrossPay(40m, 10m), 2));
        }
        [TestMethod]
        public void GrossPay_50_10()
        {
            Assert.AreEqual(550m,
                Decimal.Round(Ex3BCalculations.GrossPay(50m, 10m), 2));
        }
        [TestMethod]
        public void TotalHours()
        {
            Assert.AreEqual(10m,
                Decimal.Round(Ex3BCalculations.TotalHours("1.1 2.2 3.3 3.4 "), 2));
        }
        [TestMethod]
        public void GrossPay_String_10()
        {
            Assert.AreEqual(100m,
                Decimal.Round(Ex3BCalculations.GrossPay("1.1 2.2 3.3 3.4 ", 10m), 2));
        }
    }
}

