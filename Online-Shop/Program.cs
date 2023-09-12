/*
1. Создать пользовательский тип данных (class) для представления заказа (Order), содержащего наименование товара (тип string),
   номер телефона заказчика (тип long), стоимость (тип float), адрес доставки (тип string)
2. Создать и инциализировать массив из трех объектов класса Order, и вывести в цикле на экран полную информацию о всех заказах в массиве
*/

using Online_Shop;

Order[] orders = { new("TV LG B3 OLED", 80175550011, 6129.99f, "Minsk, Kirova str. 14, apt. 25"),
                   new("Soundbar LG SJ3", 80175550011, 770, "Minsk, Kirova str. 14, apt. 25"),
                   new("Refrigerator ATLANT 4626", 80173335544, 1629.50f, "Fanipol, Komsomolskaya str. 7, apt. 43") };

foreach (Order order in orders)
{
    Console.WriteLine(order.GetInformationFromOrder());
}
