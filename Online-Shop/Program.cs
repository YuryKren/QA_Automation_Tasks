using Online_Shop.Comparers;
using Online_Shop.Core;
using Online_Shop.Helpers;

// 1.Создать список(System.Generic.List) из объектов класса Order
List<Order> orders = new List<Order> { new("Soundbar LG SJ3", 375175550011, 770, "Minsk, Kirova str. 14, apt. 25"),
                                       new("Refrigerator ATLANT 4626", 8017173335544, 1629.55f, "Fanipol, Komsomolskaya str. 7, apt. 43"),
                                       new("Bag for notebook Lenovo", 375297775533, 45.5f, "Gomel, Petra Glebki str. 55, apt. 13"),
                                       new VIPOrder("Laptop Dell Latitude 5521", 375175550011, 7550, "Minsk, Polevaya str. 25, apt. 56", "mouse Logitech M280"),
                                       new VIPOrder("Mobile phone IPhone 14 Pro", 375333330011, 3599, "Grodno, Zamkovaya str. 15, apt. 75", "headset AirPods"),
                                       new VIPOrder("TV LG B3 OLED", 375175550011, 6129.99f, "Minsk, Kirova str. 14, apt. 25", "subscription VOKA TV 1 year"),
                                       new DiscountOrder("Microwave Samsung 3000", 80174448822, 355, "Gomel, Komsomslskaya str. 16, apt. 48", 5),
                                       new DiscountOrder("Washing machine Indesit 520T", 375296660011, 820, "Gomel, Lenina str. 25, apt. 17", 3),
                                       new DiscountOrder("Electric scooter Kugoo S3", 375296660011, 880, "Gomel, Lenina str. 25, apt. 17", 3) };

// 3. Создать отдельные классы сортировщики заказов по имени, стоимости, адресу доставки, отсортировать список по этим параметрам и вывести на экран (метод Sort() )
IComparer<Order> comparer = new NameComparer();
// orders.Sort(comparer);

// 4. Провести сортировку списка по критериям из п.3 с использованием LINQ (метод OrderBy)
var filteringList = OrderAssistance.GetFilteredList(orders, x => x.Price < 500);
var selectedFieldFromList = OrderAssistance.GetStringDataFromList(orders, x => x.Price.ToString());

var sortedListByOrderName = orders.OrderBy(x => x.Product).ToList();
var sortedListByOrderPrice = orders.OrderBy(x => x.Price).ToList();
var sortedListByOrderDeliveryAddress = orders.OrderBy(x => x.DeliveryAddress).ToList();

// 5.С использованием LINQ вывести на экран названия всех товаров из заказов, цена которых не превышает 1000 BYN, отсортированный по имени товара (методы Where, Select, OrderBy)

var sortedListWithOrderPriceLessThen100 = orders.Where(x => x.Price < 1000).OrderBy(x => x.Product).Select(x => x.Product);
foreach (var productName in sortedListWithOrderPriceLessThen100) 
{
    Console.WriteLine(productName);
}
Console.WriteLine("\n");

// 6*. Вывести на экран номера телефона, наиболее часто встречающееся в списке заказов

var groupsByPhoneNumber = orders.GroupBy(x => x.PhoneNumber).OrderByDescending(x => x.Count());
foreach (var group in groupsByPhoneNumber) 
{
    Console.WriteLine($"For phone number {group.Key}:"); 
    foreach (var order in group) 
    {
        Console.WriteLine($"\t{order.Product}");
    }
    Console.WriteLine();
}
