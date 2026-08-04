using System;

namespace Odev23_Constructor_Category.Models;

public class Category
{
    public int CategoryId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public Category(string name)
    {
        Name = name;
        Description = "";
    }

    public Category(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
