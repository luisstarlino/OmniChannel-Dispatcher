using OmniChannel.Dispatcher.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmniChannel.Dispatcher.Core.Strategies
{
    public class SmsStrategy : INotificationStrategy
    {
        public string Channel => "Sms";

        public async Task SendAsync(string message, CancellationToken ct = default)
        {
            await Task.Delay(100, ct);
            Console.WriteLine($"[SMS] Send message: {message}");
        }
    }
}
