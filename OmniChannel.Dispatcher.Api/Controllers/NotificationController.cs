using Microsoft.AspNetCore.Mvc;
using OmniChannel.Dispatcher.Api.DTOs;
using OmniChannel.Dispatcher.Core.Interfaces;

namespace OmniChannel.Dispatcher.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost]
        public async Task<IActionResult> SendNotification([FromBody] SendDTO model)
        {
            try
            {
                await _notificationService.DispatchMessage(model.Channel, model.Message);
                return Ok(model);

            } catch (Exception ex)
            {
                return Problem(
                    detail: ex.Message,
                    title: "Internal server error"
                );
            }

        }
        
    }
}
