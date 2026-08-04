using System;
using Odev18_Shipment.Models;

Shipment shipment1 = new Shipment();

shipment1.TrackingNumber = "TR001";
shipment1.SenderName = "Ali";
shipment1.ReceiverName = "Ayşe";
shipment1.ShipDate = new DateTime(2026, 8, 2);
shipment1.WeightKg = 3.5;

Shipment shipment2 = new Shipment();

shipment2.TrackingNumber = "TR002";
shipment2.SenderName = "Mehmet";
shipment2.ReceiverName = "Zeynep";
shipment2.ShipDate = new DateTime(2026, 8, 3);
shipment2.WeightKg = 7.2;

Shipment shipment3 = new Shipment();

shipment3.TrackingNumber = "TR003";
shipment3.SenderName = "Ahmet";
shipment3.ReceiverName = "Fatma";
shipment3.ShipDate = new DateTime(2026, 8, 4);
shipment3.WeightKg = 5.8;

Shipment heaviest = shipment1;

if (shipment2.WeightKg > heaviest.WeightKg)
{
    heaviest = shipment2;
}

if (shipment3.WeightKg > heaviest.WeightKg)
{
    heaviest = shipment3;
}

Console.WriteLine("En Ağır Gönderi");
Console.WriteLine($"Takip No: {heaviest.TrackingNumber}");
Console.WriteLine($"Gönderici: {heaviest.SenderName}");
Console.WriteLine($"Alıcı: {heaviest.ReceiverName}");
Console.WriteLine($"Ağırlık: {heaviest.WeightKg} kg");
