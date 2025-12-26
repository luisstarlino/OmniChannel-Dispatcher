using System;
using System.Collections.Generic;
using System.Text;

namespace OmniChannel.Dispatcher.Core.Interfaces
{
    public interface INotificationService
    {
        Task DispatchMessage(string channel, string message, CancellationToken ct = default);
    }
}
