/*Task 6
1. Добавить в программу интерфейс IDelivery с методами DeliverOrder(Order) и ExpectedDeliveryTime(Order)(метод должен возвращать примерное время доставки в зависимости отособенностей заказа)
2. Реализовать интерфейс IDelivery  нескольких сущностях- пеший доставщик,мотодоставщик, автодоставщик, дрон-доставщик. 
3. Добавить в программу  сущность DeliveryService (служба доставки, включает в себя список актуальных заказов и список доставщиков)
4. Релизовать в DeliveryService методы по добавлению и доставке заказов (при доставке у всех доставщиков из списка запрашивается время доставки, и выбирается доставщик, предложивший лучший вариант
5. Создать и доставить несколько заказов с исполозванием DeliveryService
*/
using Online_Shop.Comparers;
using Online_Shop.Core;
using Online_Shop.Helpers;

OnlineStore bigi = new ();
bigi.AddOrder(new("Soundbar LG SJ3", 375175550011, 770, "Minsk, Kirova str. 14, apt. 25"));
bigi.AddOrder(new("Refrigerator ATLANT 4626", 8017173335544, 1629.55f, "Fanipol, Komsomolskaya str. 7, apt. 43"));
bigi.AddOrder(new("Bag for notebook Lenovo", 375297775533, 45.5f, "Gomel, Petra Glebki str. 55, apt. 13"));
bigi.AddOrder(new VIPOrder("Laptop Dell Latitude 5521", 375175550011, 7550, "Minsk, Polevaya str. 25, apt. 56", "mouse Logitech M280"));
bigi.AddOrder(new VIPOrder("Mobile phone IPhone 14 Pro", 375333330011, 3599, "Grodno, Zamkovaya str. 15, apt. 75", "headset AirPods"));
bigi.AddOrder(new VIPOrder("TV LG B3 OLED", 375175550011, 6129.99f, "Minsk, Kirova str. 14, apt. 25", "subscription VOKA TV 1 year"));
bigi.AddOrder(new DiscountOrder("Microwave Samsung 3000", 80174448822, 355, "Gomel, Komsomslskaya str. 16, apt. 48", 5));
bigi.AddOrder(new DiscountOrder("Washing machine Indesit 520T", 375296660011, 820, "Gomel, Lenina str. 25, apt. 17", 3));
bigi.AddOrder(new DiscountOrder("Electric scooter Kugoo S3", 375296660011, 880, "Gomel, Lenina str. 25, apt. 17", 3));




Console.WriteLine();