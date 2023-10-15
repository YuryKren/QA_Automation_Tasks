﻿using Online_Shop.Core;
namespace Online_Shop.Interfaces
{
    internal interface IDelivery
    {
        bool DeliveryOrder(Order order);

        bool AreYouFree();

        int ExpectedDeliveryTime(Order order);

    }
}
