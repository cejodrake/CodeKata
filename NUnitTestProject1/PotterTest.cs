using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    [TestFixture]
    public class PotterTest
    {
        private Order order;

        [SetUp]
        public void Setup()
        {
            order = new Order();
        }

        [Test]
        public void No_Book_Cost_Nothing()
        {
            
            var actualPriceInCents  = order.GetOrderInCents();
              Assert.That(actualPriceInCents, Is.EqualTo(0));

        }
        [Test]
        public void One_Book_Costs_8_Dollars()
        {

        }
    }
  
    public class Order
    {
        public int GetOrderInCents()
        {
            return 0;
        }
        public void AddBook()
        {

        }
    }
}
