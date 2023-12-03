using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PieShopApp.Core.Contract.Infrastructure;
using PieShopApp.Core.Model;

namespace PieShopApp.Infrastructure;

public static class ServiceRegistration
{
	public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
	{
		services.Configure<EmailSettingsSendGridModel>(configuration.GetSection("EmailSettings_SendGrid"));
		services.AddScoped<IEmailSender, EmailSenderSendGrid>();

		services.Configure<SMSSettingsModel>(configuration.GetSection("SMSSettings"));
		services.AddScoped<ISMSSender, SMSSenderAlpha>();

		return services;
	}
}