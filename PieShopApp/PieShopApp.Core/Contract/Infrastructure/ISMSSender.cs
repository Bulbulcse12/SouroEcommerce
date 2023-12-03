using PieShopApp.Core.Model;

namespace PieShopApp.Core.Contract.Infrastructure;

public interface ISMSSender
{
	Task SendSMS(SMSModel sms);
}