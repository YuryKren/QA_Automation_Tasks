using Online_Shop.Interfaces;
namespace Online_Shop.Core.DeliveryMethod
{
    internal class MotorcycleDelivery : IDelivery
    {
        public string NumberMoto { get; }
        public string DriverName { get; }
        public string PossibleOrderWeight = "Middle, Heavy";
        private bool Free = true;
        private DateTime EndDelivery;
        public Order? deliveringOrder;

        public MotorcycleDelivery(string numberMoto, string driverName)
        {
            NumberMoto = numberMoto;
            DriverName = driverName;
        }

        public bool DeliveryOrder(Order order)
        {
            if (PossibleOrderWeight.Contains(order.DiffOfDelifery) && Free == true)
            {
                EndDelivery = DateTime.Now;
                if (order.DiffOfDelifery == "Middle")
                {
                    EndDelivery = EndDelivery.AddMinutes(30);
                }
                else
                {
                    EndDelivery = EndDelivery.AddMinutes(60);
                }
                Free = false;
                deliveringOrder = order;
                return true;
            }
            return false;
        }

        public int ExpectedDeliveryTime(Order order)
        {
            if (order.DiffOfDelifery == "Middle")
            {
                return 30;
            }
            else if (order.DiffOfDelifery == "Heavy")
            {
                return 60;
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
            Console.WriteLine(ToString());
            return false;
        }

        public override string ToString()
        {
            return $"Motodriver {DriverName} busy until {EndDelivery}, delivery {deliveringOrder?.Product}";
        }
    }
}
