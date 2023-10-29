using Online_Shop.Interfaces;
namespace Online_Shop.Core.DeliveryMethod
{
    public class Drone : IDelivery
    {
        public int InvNumber { get; }
        private string PossibleOrderWeight = "Small";
        private bool Free = true;
        private DateTime EndDelivery;
        public Order? deliveringOrder;

        public Drone(int invNumber)
        {
            InvNumber = invNumber;
        }

        public bool DeliveryOrder(Order order)
        {
            if (PossibleOrderWeight.Contains(order.DiffOfDelifery) && Free == true)
            {
                EndDelivery = DateTime.Now;
                EndDelivery = EndDelivery.AddMinutes(20);
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
                return 20;
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

        public void FinishTheExecutedDelivery()
        {
            EndDelivery = DateTime.Now;
            Free = true;
        }

        public override string ToString()
        {
            return $"Drone Inv. # {InvNumber} busy until {EndDelivery}, delivery {deliveringOrder?.Product}";
        }
    }
}
