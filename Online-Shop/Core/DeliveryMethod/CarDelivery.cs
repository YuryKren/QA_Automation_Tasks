﻿using Online_Shop.Interfaces;
namespace Online_Shop.Core.DeliveryMethod
{
    internal class CarDelivery : IDelivery
    {
        public string NumberСar {  get; }
        public string DriverName { get; }
        public string PossibleOrderWeight = "Heavy, Very heavy";
        private bool Free = true;
        private DateTime EndDelivery;
        public Order? deliveringOrder;

        public CarDelivery(string numberСar, string driverName)
        {
            NumberСar = numberСar;
            DriverName = driverName;
        }

        public bool DeliveryOrder(Order order)
        {
            if (PossibleOrderWeight.Contains(order.DiffOfDelifery) && Free == true)
            {
                EndDelivery = DateTime.Now;
                if (order.DiffOfDelifery == "Heavy") 
                {
                    EndDelivery = EndDelivery.AddMinutes(50);
                }
                else
                {
                    EndDelivery = EndDelivery.AddMinutes(70);
                }
                Free = false;
                deliveringOrder = order;
                return true;
            }
            return false;
        }

        public int ExpectedDeliveryTime(Order order)
        {
            if (order.DiffOfDelifery == "Heavy")
            {
                return 50;
            }
            else if (order.DiffOfDelifery == "Very heavy") 
            {
                return 70;
            }
            return int.MaxValue;
        }

        public bool AreYouFree()
        {
            if (EndDelivery < DateTime.Now)
            {
                deliveringOrder = null;
                Free = true;
                return true;
            }
            Console.WriteLine($"{DriverName} busy, delivery {deliveringOrder?.Product}");
            return false;
        }
    }
}