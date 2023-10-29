using Online_Shop.Core;
using Online_Shop.Core.DeliveryMethod;
using System.Diagnostics;
// 2. Написать юнит тесты для всех сущностей, включая DeliveryService

namespace Online_ShopUnitTests
{
    [TestClass]
    public class DeliveryServiceUnitTest
    {
        private static DeliveryService shop;
        private static Order smallOrder;
        private static Order middleOrder;
        private static Order heavyOrder;
        private static Order veryHeavyOrder;
        private static Order twoSmallOrder;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            shop = new("TestShop");
            smallOrder = new("Phone", 375171112233, 1000, "Minsk", 2);
            middleOrder = new("TV", 375171112233, 1000, "Minsk", 14);
            heavyOrder = new("Sound system", 375171112233, 700, "Minsk", 24);
            veryHeavyOrder = new("Car battery", 375171112233, 300, "Minsk", 25);
            twoSmallOrder = new("Phone2", 375171112233, 1000, "Minsk", 2);
        }

        [TestMethod]
        public void ChekingAddingProducts()
        {
            shop.AddProduct(smallOrder);
            shop.AddProduct(middleOrder);
            shop.AddProduct(heavyOrder);
            shop.AddProduct(veryHeavyOrder);
            Assert.IsTrue(shop.QuantityOfGoods() == 4);
        }

        [TestMethod]
        public void ChekingChoiseDeliveryMethodTest()
        {
            Assert.IsTrue(shop.DeliverMethod(smallOrder) is Drone);
            Assert.IsTrue(shop.DeliverMethod(middleOrder) is MotorcycleDelivery);
            Assert.IsTrue(shop.DeliverMethod(heavyOrder) is CarDelivery);
            Assert.IsTrue(shop.DeliverMethod(veryHeavyOrder) is CarDelivery);
        }

        [TestMethod]
        public void ChekingAcceptOrderTest() 
        {
            shop.AddProduct(smallOrder);
            shop.AddProduct(middleOrder);
            shop.AddProduct(heavyOrder);
            shop.AddProduct(veryHeavyOrder);
            shop.AcceptingOrder("Phone");
            Assert.IsTrue(shop.QuantityOfGoods() == 3);
            shop.AcceptingOrder("Sound system");
            Assert.IsTrue(shop.QuantityOfGoods() == 2);
            shop.AcceptingOrder("TV");
            Assert.IsTrue(shop.QuantityOfGoods() == 1);
            shop.AcceptingOrder("Car battery");
            Assert.IsTrue(shop.QuantityOfGoods() == 0);
        }

        [TestMethod]
        public void ChekingRejectOrderTest() 
        {
            shop.AddProduct(smallOrder);
            shop.AddProduct(twoSmallOrder);
            shop.AddProduct(middleOrder);
            shop.AddProduct(heavyOrder);
            shop.AddProduct(veryHeavyOrder);
            shop.AcceptingOrder("Phone");
            shop.AcceptingOrder("Phone2");
            shop.AcceptingOrder("TV");
            shop.AcceptingOrder("Car battery");
            shop.AcceptingOrder("Sound system");
            
            Assert.IsTrue(shop.UnfulfilledOrders() != 0);
        }
    }
}
