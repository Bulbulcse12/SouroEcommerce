using PieShopApp.Core.Model;

namespace PieShopApp.Core.Contract.Persistence;

public interface IAuthRepository
{
	Task<UserInfoModel> GetCurrentUser(string userId);
	Task<TokenModel> GetRefreshToken(string userId);
	Task UpdateRefreshToken(string userId, TokenModel token);
}