namespace BlazorApp1.Models;

public class UserProfile
{
    public string Name { get; set; } = "Alex Rivera";
    public string Location { get; set; } = "Brooklyn, NY";
    public string Bio { get; set; } = "Competitive tennis player for 10 years.";
    public double TennisRating { get; set; } = 8.4;
    public double PickleballRating { get; set; } = 4.2;
}