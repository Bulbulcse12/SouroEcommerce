using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PieShopApp.API.Persistence.Identity;

public class MembershipDbContext : IdentityDbContext<ApplicationUser>
{
	public MembershipDbContext(DbContextOptions<MembershipDbContext> options) : base(options)
	{
	}
}