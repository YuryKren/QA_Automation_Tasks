using Online_Shop.Core;
namespace Online_Shop.Comparers
{
    internal class PriceComparer : IComparer<Order>
    {
        public int Compare(Order? x, Order? y)
        {
            if (x.Price < y.Price) 
            {
                return -1;
            }
            else if (x.Price > y.Price)
            { 
                return 1; 
            }
            return 0;
        }
    }
}
