namespace Online_Shop.Core
{
    internal class VIPOrder : Order
    {
        public string Present { get; set; }

        public VIPOrder(string name, long phone, float price, string address, string present) : base(name, phone, price, address)
        {
            Present = present;
        }

        public override string GetInformationFromOrder()
        {
            return $"The order for a {Product}, client's phone number: {PhoneNumber}, " +
                   $"price: {Price} BYN, delivery address: {DeliveryAddress}, present: {Present}";
        }
    }
}
