using OmniChannel.Dispatcher.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmniChannel.Dispatcher.Core.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IEnumerable<INotificationStrategy> _strategies;

        public NotificationService(IEnumerable<INotificationStrategy> strategies)
        {
            _strategies = strategies;
        }

        public async Task DispatchMessage(string channel, string  message)
        {
            // R1.: Get the current strategy without if or switch (OCP - Open/Close Principle)
            var strategy = _strategies.FirstOrDefault(s => s.Channel.Equals(channel, StringComparison.OrdinalIgnoreCase));

            if (strategy is null)
            {
                throw new Exception($"The channel {channel} is not supported by Us!");
            }

            // R2.: Send using the correctly 
            await strategy.SendAsync(message, default);
        }

    }
}
