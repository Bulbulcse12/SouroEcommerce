using Microsoft.AspNetCore.Identity;

namespace PieShopApp.API.Persistence.Identity;

public class ApplicationUser : IdentityUser
{
	public string FullName { get; set; }
}