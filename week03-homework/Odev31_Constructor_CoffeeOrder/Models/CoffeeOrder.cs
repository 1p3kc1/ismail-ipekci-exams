namespace Odev30_Constructor_Movie.Models;

public class Movie
{
    public string Title { get; set; } = "";

    public string Director { get; set; } = "";

    public int DurationMinutes { get; set; }

    public double Rating { get; set; }

    public Movie(string title, string director)
    {
        Title = title;
        Director = director;
        DurationMinutes = 120;
    }

    public Movie(string title, string director, int durationMinutes)
    {
        Title = title;
        Director = director;
        DurationMinutes = durationMinutes;
    }
}