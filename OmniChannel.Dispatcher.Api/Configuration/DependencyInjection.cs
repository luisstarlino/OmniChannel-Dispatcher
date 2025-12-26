using FluentValidation;
using OmniChannel.Dispatcher.Api.DTOs;
using OmniChannel.Dispatcher.Core.Interfaces;
using OmniChannel.Dispatcher.Core.Services;
using OmniChannel.Dispatcher.Core.Strategies;

namespace OmniChannel.Dispatcher.Api.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddOmniChannelServices(this IServiceCollection services)
        {
            // --- Patter
            services.AddScoped<INotificationStrategy, MailStrategy>();
            services.AddScoped<INotificationStrategy, PushStrategy>();
            services.AddScoped<INotificationStrategy, SmsStrategy>();

            // --- Fluent Validation
            services.AddValidatorsFromAssemblyContaining<SendDTOValidator>(); 


            // --- Service
            services.AddScoped<INotificationService, NotificationService>();

            services.AddScoped(typeof(ValidationFilter<>));

            return services;
        }
    }
}
