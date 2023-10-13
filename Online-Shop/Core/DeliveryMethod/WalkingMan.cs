﻿using Online_Shop.Interfaces;
namespace Online_Shop.Core.DeliveryMethod
// 2. Реализовать интерфейс IDelivery  нескольких сущностях - пеший доставщик, мотодоставщик, автодоставщик, дрон-доставщик. 
{
    internal class WalkingMan : IDelivery
    {
        public string EmployeeName { get; }
        public string PossibleOrderWeight = "Small, Middle";
        private bool Free = true;
        private DateTime EndDelivery;
        public Order? deliveringOrder;

        public WalkingMan(string name) 
        {
            EmployeeName = name;
        }

        public bool DeliveryOrder(Order order)
        {
            if (PossibleOrderWeight.Contains(order.DiffOfDelifery) && Free == true)
            {
                EndDelivery = DateTime.Now;
                if (order.DiffOfDelifery == "Small")
                {
                    EndDelivery = EndDelivery.AddMinutes(30);
                }
                else
                {
                    EndDelivery = EndDelivery.AddMinutes(35);
                }
                Free = false;
                deliveringOrder = order;
                return true;
            }
            return false;
        }

        public int ExpectedDeliveryTime(Order order)
        {
            if (order.DiffOfDelifery == "Small")
            {
                return 30;
            }
            else if (order.DiffOfDelifery == "Middle")
            {
                return 35;
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
            Console.WriteLine($"{EmployeeName} busy, delivery {deliveringOrder?.Product}");
            return false;
        }
    }
}