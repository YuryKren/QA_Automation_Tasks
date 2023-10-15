using Online_Shop.Core;
namespace Online_Shop.Interfaces
// 1. Добавить в программу интерфейс IDelivery с методами DeliverOrder(Order) и ExpectedDeliveryTime(Order)
// (метод должен возвращать примерное время доставки в зависимости отособенностей заказа)
{
    internal interface IDelivery
    {
        bool DeliveryOrder(Order order);

        bool AreYouFree();

        int ExpectedDeliveryTime(Order order);

    }
}
