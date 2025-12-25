using Microsoft.AspNetCore.Mvc;
using OmniChannel.Dispatcher.Api.DTOs;

namespace OmniChannel.Dispatcher.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationController : ControllerBase
    {

        public async Task<IActionResult> SendNotification([FromBody] SendDTO model)
        {
            return Ok(model);
        }
        
    }
}
