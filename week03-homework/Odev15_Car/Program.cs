using Odev15_Car.Models;

namespace Odev15_Car;

class Program
{
    static void Main(string[] args)
    {

Car car1 = new Car();

car1.Brand = "Toyota";
car1.Model = "Corolla";
car1.Year = 2022;
car1.PlateNumber = "34 ABC 123";
car1.Color = "Beyaz";

Car car2 = new Car();

car2.Brand = "Renault";
car2.Model = "Clio";
car2.Year = 2021;
car2.PlateNumber = "06 XYZ 456";
car2.Color = "Mavi";

Car car3 = new Car();

car3.Brand = "Fiat";
car3.Model = "Egea";
car3.Year = 2023;
car3.PlateNumber = "35 DEF 789";
car3.Color = "Siyah";

Console.WriteLine($"{car1.Brand} {car1.Model} ({car1.PlateNumber})");
Console.WriteLine($"{car2.Brand} {car2.Model} ({car2.PlateNumber})");
Console.WriteLine($"{car3.Brand} {car3.Model} ({car3.PlateNumber})");
    }
}
