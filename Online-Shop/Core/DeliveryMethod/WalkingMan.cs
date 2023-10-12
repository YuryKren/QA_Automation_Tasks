using Online_Shop.Interfaces;
namespace Online_Shop.Core.DeliveryMethod
{
    internal class WalkingMan : IDelivery
    {
        List<Order> _orders;

        public WalkingMan(List<Order> orders) 
        {
            _orders = orders;
        }

        public Order DeliveryOrder(string orderProduct)
        {
            Order resultProduct = _orders.Where(x => x.Product == orderProduct).FirstOrDefault();

            if (resultProduct != null)
            {
                _orders.Remove(resultProduct);
                return resultProduct;
            }
            return null;
        }

        public DateTime ExpectedDeliveryTime(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
