using PieShopApp.Core.Model;

namespace PieShopApp.Core.Contract.Infrastructure;

public interface IEmailSender
{
	Task SendEmail(EmailModel email);
}