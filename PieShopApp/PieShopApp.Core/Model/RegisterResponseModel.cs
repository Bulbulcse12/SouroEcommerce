namespace PieShopApp.Core.Model;

public class RegisterResponseModel
{
	public bool RequireConfirmedAccount { get; set; }
	public bool SignedIn { get; set; }
	public bool UserNameExists { get; set; }
	public bool EmailExists { get; set; }
}