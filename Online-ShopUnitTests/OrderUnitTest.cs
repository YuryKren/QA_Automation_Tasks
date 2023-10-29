using Online_Shop.Core;

namespace Online_ShopUnitTests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void CheckingTheCorrectOrderNamePositive()
        {
            Order testOrder = new("testOrder", 375251111111, 100, "Minsk", 15);
            Assert.AreEqual("testOrder", testOrder.Product);
        }

        [TestMethod]
        public void CheckingTheCorrectOrderNameNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Order("", 375251111111, 100, "Minsk", 15));
        }

        [TestMethod]
        public void CheckingTheCorrectOrderPhoneNumberPositive()
        {
            Order testOrder = new("testOrder", 375251111111, 100, "Minsk", 15);
            Assert.AreEqual(375251111111, testOrder.PhoneNumber);
        }

        [TestMethod]
        public void CheckingTheCorrectOrderPhoneNumberNegative()
        {
            Order testOrder = new("testOrder", 80251111111, 100, "Minsk", 15);
            Assert.AreEqual(33344, testOrder.PhoneNumber);
        }

        [TestMethod]
        public void CheckingTheCorrectOrderPricePositive()
        {
            Order testOrder = new("testOrder", 375251111111, 9999.99f, "Minsk", 15);
            Assert.AreEqual(9999.99f, testOrder.Price);
            testOrder = new("testOrder", 375251111111, 10000.99f, "Minsk", 15);
            Assert.AreEqual(50, testOrder.Price);
            testOrder = new("testOrder", 375251111111, 49.99f, "Minsk", 15);
            Assert.AreEqual(50, testOrder.Price);
        }

        [TestMethod]
        public void CheckingTheCorrectOrderPriceNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Order("", 375251111111, 0, "Minsk", 15));
        }

        [TestMethod]
        public void CheckingTheCorrectOrderDeliveryAdressPositive()
        {
            Order testOrder = new("testOrder", 375251111111, 100, "Minsk", 15);
            Assert.AreEqual("Minsk", testOrder.DeliveryAddress);
        }

        [TestMethod]
        public void CheckingTheCorrectOrderDeliveryAdressNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Order("TV", 375251111111, 100, "", 15));
        }

        [TestMethod]
        public void CheckingTheCorrectValueOfDifficultOfDeliveryOfOrderPositive()
        {
            Order testOrder = new("testOrder", 375251111111, 100, "Minsk", 1);
            Assert.IsTrue(testOrder.DiffOfDelifery == "Small");
            testOrder = new("testOrder", 375251111111, 100, "Minsk", 3);
            Assert.IsTrue(testOrder.DiffOfDelifery == "Middle");
            testOrder = new("testOrder", 375251111111, 100, "Minsk", 15);
            Assert.IsTrue(testOrder.DiffOfDelifery == "Heavy");
            testOrder = new("testOrder", 375251111111, 100, "Minsk", 25);
            Assert.IsTrue(testOrder.DiffOfDelifery == "Very heavy");
        }

        [TestMethod]
        public void CheckingTheCorrectValueOfDifficultOfDeliveryOfOrderNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Order("TV", 375251111111, 100, "Minsk", 0));
        }

        [TestMethod]
        public void CheckingOrderSearchAtDeliveryAddress()
        {
            Order testOrder = new("testOrder", 375251111111, 100, "Minsk, Lenine street", 1);
            Assert.IsTrue(testOrder.SearchOrdersByAddress("Minsk"));
        }

        [TestMethod]
        public void CheckingTheCorrectDiscountOrderPrice()
        {
            DiscountOrder testOrder = new("testOrder", 375251111111, 100, "Minsk", 15, 1);
            Assert.AreEqual(99, testOrder.Price);
        }
    }
}
