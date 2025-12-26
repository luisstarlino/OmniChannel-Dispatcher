using FluentAssertions;
using NSubstitute;
using OmniChannel.Dispatcher.Core.Interfaces;
using OmniChannel.Dispatcher.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace OmniChannel.Dispatcher.Tests
{
    public class NotificationServiceTests
    {
        private readonly INotificationStrategy _strategyMock;
        private readonly NotificationService _sut;

        public NotificationServiceTests()
        {
            _strategyMock = Substitute.For<INotificationStrategy>();
            _strategyMock.Channel.Returns("Push");

            _sut = new NotificationService(new[] { _strategyMock });
        }

        [Fact(DisplayName = "Should dispatch message when the channel exist")]
        public async Task DispatchMessage_ValidChannel_ShouldCallStrategy()
        {
            // --- Arrange
            var ct = new CancellationTokenSource().Token;
            var message = "xUnit test pattern";

            // --- Act
            await _sut.DispatchMessage("Push", message, ct);

            // --- Assert
            await _strategyMock.Received(1).SendAsync(message, ct);
        }

        [Fact(DisplayName = "Should throw exception message when the channel don't exist")]
        public async Task DispatchMessage_InvalidChannel_ShouldCallException()
        {
            // --- Arrange
            var unsuportedChannel = "Whatsapp";

            // --- Act
            Func<Task> act =  async () => await _sut.DispatchMessage(unsuportedChannel, "fake message", default);

            // --- Assert
            await act.Should().ThrowAsync<Exception>().WithMessage($"The channel {unsuportedChannel} is not supported by Us!");
        }
    }
}
