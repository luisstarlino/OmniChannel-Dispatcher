using OmniChannel.Dispatcher.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmniChannel.Dispatcher.Core.Strategies
{
    public class MailStrategy : INotificationStrategy
    {
        public string Channel => "Mail";

        public async Task SendAsync(string message, CancellationToken ct = default)
        {
            await Task.Delay(100, ct);
            Console.WriteLine($"[MAIL] Send message: {message}");
        }
    }
}
