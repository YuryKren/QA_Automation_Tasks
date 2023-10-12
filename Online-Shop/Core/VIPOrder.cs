namespace Online_Shop.Core
{
    internal class VIPOrder : Order
    {
        public string Present { get; set; }

        public VIPOrder(string name, long phone, float price, string address, int weight, string present) : base(name, phone, price, address, weight)
        {
            Present = present;
        }

        public override string GetInformationFromOrder()
        {
            return $"{Product}, client's phone number: {PhoneNumber}, " +
                   $"price: {Price} BYN, delivery address: {DeliveryAddress}, difficulty of delivery: {DiffOfDelifery}, present: {Present}";
        }
    }
}
