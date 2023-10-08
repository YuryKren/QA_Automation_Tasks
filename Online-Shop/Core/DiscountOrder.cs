namespace Online_Shop.Core
{
    internal class DiscountOrder : Order
    {
        public float Discount { get; set; }

        private float _price;
        public new float Price
        {
            get { return _price; }
            set { _price = value * Discount / 100; }
        }

        public DiscountOrder(string name, long phone, float price, string address, float discount) : base(name, phone, price, address)
        {
            Discount = discount;
        }

        public override string GetInformationFromOrder()
        {
            return $"The order for a {Product}, client's phone number: {PhoneNumber}, " +
                   $"price: {Price} BYN, delivery address: {DeliveryAddress}, discount {Discount}";
        }
    }
}
