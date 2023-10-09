using Online_Shop.Core;
namespace Online_Shop.Comparers
{
    internal class DeliveryAddressComparer : IComparer<Order>
    {
        public int Compare(Order? x, Order? y)
        {
            return x.DeliveryAddress.CompareTo(y.DeliveryAddress);
        }
    }
}
