using Online_Shop.Core;
namespace Online_Shop.Helpers
{
    internal class ListFiltering
    {
        public delegate bool FilteringCondition(Order order);
        public static List<Order> GetFilteredList(List<Order> list, FilteringCondition predicate) 
        {
            List<Order> filtered = new();
            foreach (var item in list) 
            {
                if (predicate(item)) 
                {
                    filtered.Add(item);
                }
            }
            return filtered;
        }
    }
}
