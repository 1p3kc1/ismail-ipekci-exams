namespace Odev33_Constructor_Athlete.Models;

public class Athlete
{
    public string FullName { get; set; } = "";

    public string SportBranch { get; set; } = "";

    public string TeamName { get; set; } = "";

    public int JerseyNumber { get; set; }

    public Athlete(string fullName, string sportBranch)
    {
        FullName = fullName;
        SportBranch = sportBranch;
        TeamName = "Free Agent";
    }

    public Athlete(string fullName, string sportBranch, string teamName, int jerseyNumber)
    {
        FullName = fullName;
        SportBranch = sportBranch;
        TeamName = teamName;
        JerseyNumber = jerseyNumber;
    }
}