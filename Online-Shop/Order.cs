using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop
{
    
    internal class Order
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
                if (value >= 0 && value < 2000) 
                {
                    _price = value;
                }
            }
        }
        public string DeliveryAddress {  get; set; }

        public Order(string name, long phone, float price, string address)
        {
            Product = name;
            PhoneNumber = phone;
            Price = price;
            DeliveryAddress = address;
        }

        public string GetInformationFromOrder()
        {
            return $"The order for a {Product}, client's phone number: {PhoneNumber}, " +
                   $"price: {Price} BYN, delivery address: {DeliveryAddress}";
        }
    }
}
