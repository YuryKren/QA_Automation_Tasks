using Online_Shop.Core;
namespace Online_Shop.Helpers
{
    internal class OrderAssistance
    {
        public static List<Order> GetFilteredList(List<Order> list, Func<Order, bool> predicate) 
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

        public static List<string> GetStringDataFromList(List<Order> list, Func<Order, string> selector) 
        {
            List<string> selected = new();
            foreach (var item in list) 
            {
                selected.Add(selector(item));
            }
            return selected;
        }
    }
}
