using CQRS_DOTNET_SAMPLE.ApplicationCore.Features.Tasks.Command;
using CQRS_DOTNET_SAMPLE.ApplicationCore.Features.Tasks.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_DOTNET_SAMPLE.API.Controllers
{
    public class MeetingControllers : ControllerBase
    {
        private readonly ISender _sender;
        public MeetingControllers(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet("/getmeetings")]
        public ActionResult GetAllMeetings()
        {
           var result = _sender.Send(new GetAllMeetingsQuery());
            return Ok(result);
        }


        [HttpPost("/addmeeting")]
        public ActionResult CreateMeeting(AddMeetingCommand meeting)
        {
            _sender.Send(meeting);
            return Ok();
        }
    }
}
