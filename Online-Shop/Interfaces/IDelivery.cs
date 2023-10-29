using Online_Shop.Core;
namespace Online_Shop.Interfaces
{
    public interface IDelivery
    {
        bool DeliveryOrder(Order order);

        bool AreYouFree();

        int ExpectedDeliveryTime(Order order);

        void FinishTheExecutedDelivery();

    }
}
