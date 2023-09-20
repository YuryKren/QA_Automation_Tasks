/*
1. Ввести новый типы данных VIPOrder, DiscountOrder и OrdinaryOrder (наследники от Order). 
1.1 В VIPOrder добавить property с описанием  подарка от службы доставки (string)
1.2 В DiscountOrder добавить property с размером скидки (float) 
2. Для всех типов реализовать соответствующие конструкторы
3. Создать массив из Order разлиных типов, вывести на экран полную информацию о них
*/

using Online_Shop;
using System;

Order[] orders = { new("TV LG B3 OLED", 375175550011, 6129.99f, "Minsk, Kirova str. 14, apt. 25"),
                   new("soundbar LG SJ3", 80175550011, 770, "Minsk, Kirova str. 14, apt. 25"),
                   new("refrigerator ATLANT 4626", 375173335544, 1629.55f, "Fanipol, Komsomolskaya str. 7, apt. 43"),
                   new("washing machine Indesit 520T", 375296660011, 820, "Gomel, Lenina str. 25, apt. 17"),
                   new("microwave Samsung 3000", 80174448822, 355, "Gomel, Komsomslskaya str. 16, apt. 48"),
                   new("bag for notebook Lenovo", 375297775533, 45.5f, "Gomel, Petra Glebki str. 55, apt. 13"),
                   new VIPOrder("laptop Dell Latitude 5521", 375299995500, 7550, "Minsk, Polevaya str. 25, apt. 56", "mouse Logitech M280") };

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
