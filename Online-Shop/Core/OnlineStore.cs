namespace Online_Shop.Core
{
    internal class OnlineStore
    {
        public string Name { get; }
        List<Order> orders = new List<Order>();

        public OnlineStore(string name)
        {
            Name = name;
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
    }
}
