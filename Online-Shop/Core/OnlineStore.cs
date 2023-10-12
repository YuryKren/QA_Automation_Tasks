using Online_Shop.Core.DeliveryMethod;
using Online_Shop.Interfaces;

namespace Online_Shop.Core
{
    internal class OnlineStore
    {
        public string Name { get; }
        List<Order> _orders = new List<Order>();
        List<IDelivery> _deliveries = new List<IDelivery>();

        public OnlineStore(string name)
        {
            Name = name;
            _deliveries.Add(new WalkingMan(_orders));
            _deliveries.Add(new MotorcycleDelivery(_orders));
            _deliveries.Add(new CarDelivery(_orders));
            _deliveries.Add(new Drone(_orders));
        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public Order OrderProduct(string orderProduct) 
        {
            return _deliveries.FirstOrDefault().DeliveryOrder(orderProduct);
        }
    }
}
