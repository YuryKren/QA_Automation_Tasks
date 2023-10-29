using Microsoft.VisualStudio.TestTools.UnitTesting;
using Online_Shop.Core;
using Online_Shop.Core.DeliveryMethod;
using System.Diagnostics;

namespace Online_ShopUnitTests
{
    [TestClass]
    public class CarDeliveryUnitTest
    {
        private static CarDelivery carDelivery;
        private static Order smallOrder;
        private static Order middleOrder;
        private static Order heavyOrder;
        private static Order veryHeavyOrder;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            carDelivery = new("1111", "Ivanov");
            smallOrder = new("Phone", 375171112233, 1000, "Minsk", 2);
            middleOrder = new("TV", 375171112233, 1000, "Minsk", 14);
            heavyOrder = new("Sound system", 375171112233, 700, "Minsk", 24);
            veryHeavyOrder = new("Car battery", 375171112233, 300, "Minsk", 25);
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Test Car Delivery initialize");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("Test Car Delivery cleanup");
        }

        [TestMethod]
        public void ChekingDeliveryOrderMethodWithDifferentOrders()
        {
            Assert.IsFalse(carDelivery.DeliveryOrder(smallOrder));
            Assert.IsFalse(carDelivery.DeliveryOrder(middleOrder));
            Assert.IsTrue(carDelivery.DeliveryOrder(heavyOrder));
            Assert.AreSame(carDelivery.deliveringOrder, heavyOrder);
            carDelivery.FinishTheExecutedDelivery();
            Assert.IsTrue(carDelivery.DeliveryOrder(veryHeavyOrder));
            Assert.AreSame(carDelivery.deliveringOrder, veryHeavyOrder);
        }

        [TestMethod]
        public void ChekingExpectedDeliveryTime()
        {
            Assert.AreEqual(int.MaxValue, carDelivery.ExpectedDeliveryTime(smallOrder));
            Assert.AreEqual(int.MaxValue, carDelivery.ExpectedDeliveryTime(middleOrder));
            Assert.IsTrue(carDelivery.ExpectedDeliveryTime(heavyOrder) == 50);
            Assert.IsTrue(carDelivery.ExpectedDeliveryTime(veryHeavyOrder) == 70);
        }

        [TestMethod]
        public void StatusСheckAreFreeOrNot() 
        {
            carDelivery.FinishTheExecutedDelivery();
            Assert.IsTrue(carDelivery.AreYouFree());
            carDelivery.DeliveryOrder(heavyOrder);
            Assert.IsFalse(carDelivery.AreYouFree());
        }
    }
}
