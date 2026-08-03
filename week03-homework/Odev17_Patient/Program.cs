using Odev17_Patient.Models;

namespace Odev17_Patient;

class Program
{
    static void Main(string[] args)
    {
Patient patient1 = new Patient();

patient1.PatientId = "1001";
patient1.FullName = "Ali Yılmaz";
patient1.BirthDate = new DateTime(2000, 5, 10);
patient1.BloodType = "A Rh+";

Patient patient2 = new Patient();

patient2.PatientId = "1002";
patient2.FullName = "Ayşe Demir";
patient2.BirthDate = new DateTime(1998, 11, 25);
patient2.BloodType = "0 Rh-";

Console.WriteLine("1. Hasta");
Console.WriteLine($"Adı: {patient1.FullName}");
Console.WriteLine($"Kan Grubu: {patient1.BloodType}");

Console.WriteLine();

Console.WriteLine("2. Hasta");
Console.WriteLine($"Adı: {patient2.FullName}");
Console.WriteLine($"Kan Grubu: {patient2.BloodType}");
    }
}
