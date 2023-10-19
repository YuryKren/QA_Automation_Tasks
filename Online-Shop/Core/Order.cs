namespace Online_Shop.Core
// 1. Для всех свойств в классах заказа ввести проверку валидности значений в set части, в случае невалидности введенного значения выбрасывать исключения
{
    internal class Order : IComparable<Order>
    {
        private string _product;
        public string Product 
        {
            get 
            {
                return _product;
            }
            set 
            {
                if (value.Length == 0) 
                {
                    throw new ArgumentException("Wrong product name");
                }
                _product = value;
            }
        }

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
                if (value <= 0) 
                {
                    throw new ArgumentException("Wrong price");
                }
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

        private string _deliveryAddress;
        public string DeliveryAddress
        {
            get
            {
                return _deliveryAddress;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Wrong delivery address");
                }
                _deliveryAddress = value;
            }
        }

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
            if (weight <= 0) 
            {
                throw new ArgumentException("Wrong weight");
            }
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
