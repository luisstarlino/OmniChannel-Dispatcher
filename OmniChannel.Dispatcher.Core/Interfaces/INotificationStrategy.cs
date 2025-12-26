using System;
using System.Collections.Generic;
using System.Text;

namespace OmniChannel.Dispatcher.Core.Interfaces
{
    public interface INotificationStrategy
    {
        string Channel { get; }
        Task SendAsync(string message, CancellationToken ct = default);
    }
}
