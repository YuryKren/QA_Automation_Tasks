using Online_Shop.Core.DeliveryMethod;
using Online_Shop.Interfaces;

namespace Online_Shop.Core
{
    public class DeliveryService
    {
        public string Name { get; }
        List<Order> _goods = new List<Order>();
        List<Order> _deliveryQueue = new List<Order>();
        List<IDelivery> _deliveries = new List<IDelivery>();
        public DeliveryService(string name)
        {
            Name = name;
            _deliveries.Add(new Drone(3344));
            _deliveries.Add(new WalkingMan("Vitaly"));
            _deliveries.Add(new MotorcycleDelivery("8411 MK-6", "Sergey"));
            _deliveries.Add(new CarDelivery("5420 TP-7", "Eugen"));
        }
        public void AddProduct(Order order)
        {
            _goods.Add(order);
        }

        public IDelivery DeliverMethod(Order item)
        {
            return _deliveries.Where(x => x.AreYouFree()).OrderBy(x => x.ExpectedDeliveryTime(item)).FirstOrDefault();
        }

        public void AcceptingOrder(string order) 
        {
            Order result = null;
            foreach (Order item in _goods) 
            {
                if(item.Product.Contains(order))
                {
                    _deliveryQueue.Add(item);
                    _goods.Remove(item);
                    result = item;
                    break;
                }
            }
            var currentDeliveryMethod = DeliverMethod(result);
            if (currentDeliveryMethod != null) 
            {
                currentDeliveryMethod.DeliveryOrder(result);
                _deliveryQueue.Remove(result);
            }
            else 
            {
                Console.WriteLine($"Unfortunately, we cannot deliver the {result.Product} since all the couriers are busy." +
                                  $" We will deliver it over the next hour");
            }
        }

        public int UnfulfilledOrders() 
        {
            return _deliveryQueue.Count;
        }

        public int QuantityOfGoods()
        { 
            return _goods.Count;
        }

    }
}
