using OmniChannel.Dispatcher.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OmniChannel.Dispatcher.Core.Strategies
{
    public class PushStrategy : INotificationStrategy
    {
        public string Channel => "Push";

        public async Task SendAsync(string message, CancellationToken ct = default)
        {
            await Task.Delay(50, ct);
            Console.WriteLine($"[PUSH] Send message: {message}");
        }
    }
}
