using MediatR;

namespace CQRS_DOTNET_SAMPLE.ApplicationCore.Features.Tasks.Command
{
    public class AddMeetingCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Priority { get; set; }
        public DateTimeOffset From { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset To { get; set; } = DateTimeOffset.Now;
    }
}
