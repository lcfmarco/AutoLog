// Creates a user model, and ties a list of cars to the user

using Microsoft.AspNetCore.Identity;

namespace AutoLog.Models;

public class User : IdentityUser
{
    // ICollection: interface in .NET that represents a collection of items
    // You can add, remove and count with this, unlike a regular List
    public ICollection<Car> Cars { get; set; } = new List<Car>();
    
}