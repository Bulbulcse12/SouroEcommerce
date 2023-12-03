using System.ComponentModel.DataAnnotations;
using Xunit;

namespace PieShopApp.Core.Model;

public class UserInfoModel
{
	public string Id { get; set; }

	[RegularExpression(@"^[a-zA-Z][a-zA-Z.]*[a-zA-Z]$", ErrorMessage = "Username cannot start or end with a dot and must consist of letters.")]
	public string UserName { get; set; }

	public string Name { get; set; }

	[DataType(DataType.EmailAddress)]
	[EmailAddress(ErrorMessage = "Invalid Email Address")]
	public string Email { get; set; }


	[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{6,}$", ErrorMessage = "Password must contain at least one lowercase letter, one uppercase letter, one symbol, one number, and be at least 6 characters long.")]
	public string Password { get; set; }



}


//public class UserInfoModel
//{
//	public string Id { get; set; }
//	public string UserName { get; set; }
//	public string Password { get; set; }
//	public string Name { get; set; }

//	public string Email { get; set; }
//	public string PhoneNumber { get; set; }
//	public string Role { get; set; }
//}