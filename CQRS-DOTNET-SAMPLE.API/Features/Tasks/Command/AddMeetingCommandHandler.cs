using CQRS_DOTNET_SAMPLE.API;
using MediatR;

namespace CQRS_DOTNET_SAMPLE.ApplicationCore.Features.Tasks.Command
{
    public class AddMeetingCommandHandler : IRequestHandler<AddMeetingCommand,Unit>
    {
        private MeetingDbContext _dbContext;

        public AddMeetingCommandHandler(MeetingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(AddMeetingCommand request, CancellationToken cancellationToken)
        {
            var meeting = new Meeting()
            {
                Id = request.Id,
                Description = request.Description,
                Title = request.Title,
                Priority = request.Priority,
                From = request.From,
                To = request.To
            };

            _dbContext.Meetings.Add(meeting);
            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
