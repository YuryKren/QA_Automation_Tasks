using Online_Shop.Core;
namespace Online_Shop.Helpers
{
    internal class ListFiltering
    {
        public static List<Order> GetFilteredListAtPrice(List<Order> list, float price) 
        {
            List<Order> filtered = new();
            foreach (var item in list) 
            {
                if (item.Price < price) 
                {
                    filtered.Add(item);
                }
            }
            return filtered;
        }
    }
}
