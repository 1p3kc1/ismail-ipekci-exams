namespace MVC_TravelGuide.Models.Entities;

public class Place
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public int EntryFee { get; set; }
}