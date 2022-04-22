using MassTransit;
using MasstransitDemo.Api.Models;
using MasstransitDemo.Shared;
using Microsoft.AspNetCore.Mvc;

namespace MasstransitDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        public readonly IPublishEndpoint publishEndpoint;

        public NotificationController(IPublishEndpoint publishEndpoint)
        {
            this.publishEndpoint = publishEndpoint;
        }

        [HttpPost]
        public async Task Notify(NotificationModel model)
        {
            await publishEndpoint.Publish<INotificationSubmitted>(new NotificationSubmitted
            {
                NotificationDate = model.NotificationDate,
                NotificationMessage = model.NotificationMessage,
                NotificationType = model.NotificationType
            });
        }
    }
}