using BlazorApp1.Models;

namespace BlazorApp1.Services;

public class ProfileService
{
    public UserProfile User { get; set; } = new UserProfile();
}