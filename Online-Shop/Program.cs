/*
Task 5
1. Создать список (System.Generic.List) из объектов класса Order
2. Реализовать в классе Order интерфейс IComparable для сортироваке по умолчанию (по телефону заказчика)
3. Создать отдельные классы сортировщики заказов по имени, стоимости, адресу доставки, отсортировать список по этим параметрам и вывести на экран (метод Sort() )
4. Провести сортировку списка по критериям из п.3 с использованием LINQ (метод OrderBy)
5. С использованием LINQ вывести на экран названия всех товаров из заказов, цена которых не превышает 100$, отсортированный по имени товара (методы Where, Select, OrderBy)
6*. Вывести на экран название товара, наиболее часто встречающееся в списке заказов
*/

using Online_Shop;
using System;
using System.Collections.Generic;

Order[] orders = { new("soundbar LG SJ3", 80175550011, 770, "Minsk, Kirova str. 14, apt. 25"),
                   new("refrigerator ATLANT 4626", 375173335544, 1629.55f, "Fanipol, Komsomolskaya str. 7, apt. 43"),
                   new("washing machine Indesit 520T", 375296660011, 820, "Gomel, Lenina str. 25, apt. 17"),
                   new VIPOrder("laptop Dell Latitude 5521", 375299995500, 7550, "Minsk, Polevaya str. 25, apt. 56", "mouse Logitech M280"),
                   new VIPOrder("mobile phone IPhone 14 Pro", 375333330011, 3599, "Grodno, Zamkovaya str. 15, apt. 75", "headset AirPods"),
                   new VIPOrder("TV LG B3 OLED", 375175550011, 6129.99f, "Minsk, Kirova str. 14, apt. 25", "subscription VOKA TV 1 year"),
                   new DiscountOrder("microwave Samsung 3000", 80174448822, 355, "Gomel, Komsomslskaya str. 16, apt. 48", 5),
                   new DiscountOrder("bag for notebook Lenovo", 375297775533, 45.5f, "Gomel, Petra Glebki str. 55, apt. 13", 3),
                   new DiscountOrder("electric scooter Kugoo S3", 375441212120, 880, "Gomel, Lenina str. 25, apt. 17", 3) };


MyList<Order> list = new ();
list.AddElement(orders[0]);
list.AddElement(orders[1]);
list.AddElement(orders[3]);
list.AddElement(orders[4]);
list.AddElement(orders[6]);

Order numAvailableOrder = orders[3];
Console.WriteLine($"Order number for {numAvailableOrder.Product} in list - {list.NumberAvailableElement(numAvailableOrder)}");

Console.WriteLine($"Actual number of elements in the list - {list.ActualNumberElementsList()}");

int numByList = 3;
Console.WriteLine($"The number {numByList} in the list is {list.GetElementByNumber(numByList).Product}");

list.Remove(numAvailableOrder);
Console.WriteLine($"Order number for {numAvailableOrder.Product} in list - {list.NumberAvailableElement(numAvailableOrder)}");

Console.WriteLine($"Actual number of elements in the list - {list.ActualNumberElementsList()}");

int orderFromList = 0;
while (orderFromList < list.ActualNumberElementsList())
{
    Console.WriteLine(list.GetElementByNumber(orderFromList).ToString());
    orderFromList++;
}

foreach (var item in list)
{
    Console.WriteLine(item.ToString());
}