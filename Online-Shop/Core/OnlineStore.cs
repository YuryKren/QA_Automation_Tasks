namespace Online_Shop.Core
{
    internal class OnlineStore
    {
        List<Order> orders = new List<Order>();


        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
    }
}
