using Odev27_Constructor_Employee.Models;

Employee employee1 = new Employee("Ali Yılmaz");
employee1.EmployeeId = 1;
employee1.Salary = 35000;

Employee employee2 = new Employee("Ayşe Demir", "Senior");
employee2.EmployeeId = 2;
employee2.Salary = 60000;

Console.WriteLine("1. Personel");
Console.WriteLine($"Ad Soyad: {employee1.FullName}");
Console.WriteLine($"Pozisyon: {employee1.Position}");
Console.WriteLine($"Maaş: {employee1.Salary}");

Console.WriteLine();

Console.WriteLine("2. Personel");
Console.WriteLine($"Ad Soyad: {employee2.FullName}");
Console.WriteLine($"Pozisyon: {employee2.Position}");
Console.WriteLine($"Maaş: {employee2.Salary}");