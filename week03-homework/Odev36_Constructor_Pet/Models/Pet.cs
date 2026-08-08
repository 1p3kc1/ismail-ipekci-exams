using System;

namespace Odev36_Constructor_Pet.Models;

public class Pet
{
    public string Name { get; set; } 

    public string Type { get; set; } 

    public int Age { get; set; }

    public string OwnerName { get; set; }

    public Pet(string name, string ownerName)
    {
        Name = name;
        OwnerName = ownerName;
        Type = "Unknown";
    }

    public Pet(string name, string ownerName, string type, int age)
    {
        Name = name;
        OwnerName = ownerName;
        Type = type;
        Age = age;
    }
}