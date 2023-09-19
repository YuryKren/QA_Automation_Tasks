/*
1. В созданном в Task 1 типе данных Order все поля представить в виде свойств (Property)
2. Для номера телефона заказчика в свойстве в set части добавить  проверку (в номере должно быть ровно 12 цифр)
3. Для стоимости товара в set части добавить проверку (стомость должна быть не меньше 100 и не превышать 10000)
4. Вывести на экран полную информацию о заказах, телефонный номер заказчика которых начинается на 375.
5. Вывести на экран полную информацию о заказах, стоимость которых не меньше 300 и адрес заказчика начинается на "Gomel".
*/

using Online_Shop;
using System;

Order[] orders = { new("TV LG B3 OLED", 375175550011, 6129.99f, "Minsk, Kirova str. 14, apt. 25"),
                   new("soundbar LG SJ3", 80175550011, 770, "Minsk, Kirova str. 14, apt. 25"),
                   new("refrigerator ATLANT 4626", 375173335544, 1629.55f, "Fanipol, Komsomolskaya str. 7, apt. 43"),
                   new("washing machine Indesit 520T", 375296660011, 820, "Gomel, Lenina str. 25, apt. 17"),
                   new("microwave Samsung 3000", 80174448822, 355, "Gomel, Komsomslskaya str. 16, apt. 48"),
                   new("bag for notebook Lenovo", 375297775533, 45.5f, "Gomel, Petra Glebki str. 55, apt. 13") };

Console.WriteLine("\n\t\t\tThe fourth point homework\n");
foreach (Order order in orders)
{
    long firstDigitNumber = order.PhoneNumber;
    firstDigitNumber /= 1000000000;
    if (firstDigitNumber == 375) 
    {
        Console.WriteLine(order.GetInformationFromOrder());
    }
}

Console.WriteLine("\n\n\t\t\tThe fiveth point homework\n");
foreach (Order order in orders) 
{
    if (order.Price >= 300 && order.SearchOrdersByAddress("Gomel")) 
    {
        Console.WriteLine(order.GetInformationFromOrder());
    }
}
