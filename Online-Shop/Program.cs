/*
1. В созданном в Task 1 типе данных Order все поля представить в виде свойств (Property)
2. Для номера телефона заказчика в свойстве в set части добавить  проверку (в номере должно быть ровно 13 цифр)
3. Для стоимости товара в set части добавить проверку (стомость должна быть положительной, но не превышать 1000)
4. Вывести на экран полную информацию о заказах, телефонный номер заказчика которых начинается на 375.
5. Вывести на экран полную информацию о заказах, стоимость которых не превышает 20 и имя товара начинается на "Whys".
*/

using Online_Shop;

Order[] orders = { new("TV LG B3 OLED", 375175550011, 6129.99f, "Minsk, Kirova str. 14, apt. 25"),
                   new("soundbar LG SJ3", 80175550011, 770, "Minsk, Kirova str. 14, apt. 25"),
                   new("refrigerator ATLANT 4626", 375173335544, 1629.55f, "Fanipol, Komsomolskaya str. 7, apt. 43") };

foreach (Order order in orders)
{
    if (order.PhoneNumber > 0) 
    {
        Console.WriteLine(order.GetInformationFromOrder());
    }
    
}
