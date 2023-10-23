using Online_Shop.Core.DeliveryMethod;
using Online_Shop.Interfaces;

namespace Online_Shop.Core
{
    public class DeliveryService
    {
        public string Name { get; }
        List<Order> _goods = new List<Order>();
        List<Order> _toDelivery = new List<Order>();
        List<IDelivery> _deliveries = new List<IDelivery>();
        public DeliveryService(string name)
        {
            Name = name;
            _deliveries.Add(new Drone(3344));
            _deliveries.Add(new WalkingMan("Vitaly"));
            _deliveries.Add(new MotorcycleDelivery("8411 MK-6", "Sergey"));
            _deliveries.Add(new CarDelivery("5420 TP-7", "Eugen"));
        }
        public void AddOrder(Order order)
        {
            _goods.Add(order);
        }

        private IDelivery DeliverMethod(Order item)
        {
            return _deliveries.Where(x => x.AreYouFree()).OrderBy(x => x.ExpectedDeliveryTime(item)).First();
        }

        public void AcceptingOrder(string order) 
        {
            Order result = null;
            foreach (Order item in _goods) 
            {
                if(item.Product.Contains(order))
                {
                    _toDelivery.Add(item);
                    _goods.Remove(item);
                    result = item;
                    break;
                }
            }
            var currentDeliveryMethod = DeliverMethod(result);
            if (currentDeliveryMethod.DeliveryOrder(result)) 
            {
                _toDelivery.Remove(result);
            }
            else 
            {
                if (result.DiffOfDelifery == "Small")
                {
                    _deliveries.Add(new Drone(3355));
                    DeliverMethod(result).DeliveryOrder(result);
                    _toDelivery.Remove(result);
                }
                else if (result.DiffOfDelifery == "Middle") 
                {
                    _deliveries.Add(new WalkingMan("Maksim"));
                    DeliverMethod(result).DeliveryOrder(result);
                    _toDelivery.Remove(result);
                }
                else if (result.DiffOfDelifery == "Heavy")
                {
                    _deliveries.Add(new MotorcycleDelivery("8422 MK-6", "Ivan"));
                    DeliverMethod(result).DeliveryOrder(result);
                    _toDelivery.Remove(result);
                }
                else if (result.DiffOfDelifery == "Very heavy") 
                {
                    _deliveries.Add(new CarDelivery("5430 TP-7", "Dmitry"));
                    DeliverMethod(result).DeliveryOrder(result);
                    _toDelivery.Remove(result);
                }
            }
        }

    }
}
