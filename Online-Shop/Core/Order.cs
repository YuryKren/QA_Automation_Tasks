namespace Online_Shop.Core
{
    internal class Order : IComparable<Order>
    {
        public string Product { get; set; }

        private long _phoneNumber;
        public long PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                string temp = value.ToString();
                if (temp.Length == 12)
                {
                    _phoneNumber = value;
                }
                else
                {
                    _phoneNumber = 33344;  // our sales department number
                }
            }
        }

        private float _price;
        public float Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 50 && value < 10000)
                {
                    _price = value;
                }
                else
                {
                    _price = 50;  // minimum order cost with delivery
                }
            }
        }
        public string DeliveryAddress { get; set; }

        public string DiffOfDelifery { get; set; }

        public Order(string name, long phone, float price, string address, int weight)
        {
            Product = name;
            PhoneNumber = phone;
            Price = price;
            DeliveryAddress = address;
            DiffOfDelifery = DifficultOfDelivery(weight);
        }

        public virtual string GetInformationFromOrder()
        {
            return $"{Product}, client's phone number: {PhoneNumber}, " +
                   $"price: {Price} BYN, delivery address: {DeliveryAddress}, difficulty of delivery: {DiffOfDelifery}";
        }

        public string DifficultOfDelivery(int weight) 
        {
            if (weight < 3) 
            {
                return "Small";
            }
            else if (weight >= 3 && weight < 15)
            {
                return "Middle";
            }
            else if (weight >= 15 && weight < 25) 
            {
                return "Heavy";
            }
            else 
            {
                return "Very heavy";
            }
        }
        public bool SearchOrdersByAddress(string address)
        {
            if (DeliveryAddress.Contains(address))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return GetInformationFromOrder();
        }

        public int CompareTo(Order? other)
        {
            if (PhoneNumber < other.PhoneNumber) 
            {
                return -1;
            }
            else if (PhoneNumber > other.PhoneNumber) 
            {
                return 1;
            }
            return 0;
        }
    }
}
