﻿using Online_Shop.Core.DeliveryMethod;
using Online_Shop.Interfaces;

namespace Online_Shop.Core
// 3. Добавить в программу  сущность DeliveryService (служба доставки, включает в себя список актуальных заказов и список доставщиков)
{
    internal class DeliveryService
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
        // 4. Релизовать в DeliveryService методы по добавлению и доставке заказов (при доставке у всех доставщиков из списка
        // запрашивается время доставки, и выбирается доставщик, предложивший лучший вариант)
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
            DeliverMethod(result).DeliveryOrder(result);
            
        }

    }
}