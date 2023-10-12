using Online_Shop.Core;
// 1. Добавить в программу интерфейс IDelivery с методами DeliverOrder(Order) и ExpectedDeliveryTime(Order)
// (метод должен возвращать примерное время доставки в зависимости отособенностей заказа)

namespace Online_Shop.Interfaces
{
    internal interface IDelivery
    {
        Order DeliveryOrder(string orderProduct);

        DateTime ExpectedDeliveryTime(Order order);

    }
}
