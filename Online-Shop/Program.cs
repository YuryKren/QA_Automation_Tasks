/*
5. С использованием LINQ вывести на экран названия всех товаров из заказов, цена которых не превышает 100$, отсортированный по имени товара (методы Where, Select, OrderBy)
6*. Вывести на экран название товара, наиболее часто встречающееся в списке заказов
*/

using Online_Shop.Collections;
using Online_Shop.Comparers;
using Online_Shop.Core;
using Online_Shop.Helpers;

// 1.Создать список(System.Generic.List) из объектов класса Order
List<Order> orders = new List<Order> { new("Soundbar LG SJ3", 80175550011, 770, "Minsk, Kirova str. 14, apt. 25"),
                                       new("Refrigerator ATLANT 4626", 375173335544, 1629.55f, "Fanipol, Komsomolskaya str. 7, apt. 43"),
                                       new("Bag for notebook Lenovo", 375297775533, 45.5f, "Gomel, Petra Glebki str. 55, apt. 13"),
                                       new VIPOrder("Laptop Dell Latitude 5521", 375299995500, 7550, "Minsk, Polevaya str. 25, apt. 56", "mouse Logitech M280"),
                                       new VIPOrder("Mobile phone IPhone 14 Pro", 375333330011, 3599, "Grodno, Zamkovaya str. 15, apt. 75", "headset AirPods"),
                                       new VIPOrder("TV LG B3 OLED", 375175550011, 6129.99f, "Minsk, Kirova str. 14, apt. 25", "subscription VOKA TV 1 year"),
                                       new DiscountOrder("Microwave Samsung 3000", 80174448822, 355, "Gomel, Komsomslskaya str. 16, apt. 48", 5),
                                       new DiscountOrder("Washing machine Indesit 520T", 375296660011, 820, "Gomel, Lenina str. 25, apt. 17", 3),
                                       new DiscountOrder("Electric scooter Kugoo S3", 375441212120, 880, "Gomel, Lenina str. 25, apt. 17", 3) };

// 3. Создать отдельные классы сортировщики заказов по имени, стоимости, адресу доставки, отсортировать список по этим параметрам и вывести на экран (метод Sort() )
IComparer<Order> comparer = new DeliveryAddressComparer();
orders.Sort(comparer);

// 4. Провести сортировку списка по критериям из п.3 с использованием LINQ (метод OrderBy)
var filteringListLessThanPrice = ListFiltering.GetFilteredList(orders, delegate (Order order) {return order.Price < 500;});


Console.WriteLine(filteringListLessThanPrice.Count);
