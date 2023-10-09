using Online_Shop.Core;
namespace Online_Shop.Comparers
{
    internal class NameComparer : IComparer<Order>
    {
        public int Compare(Order? x, Order? y)
        {
            return x.Product.CompareTo(y.Product);
        }
    }
}
