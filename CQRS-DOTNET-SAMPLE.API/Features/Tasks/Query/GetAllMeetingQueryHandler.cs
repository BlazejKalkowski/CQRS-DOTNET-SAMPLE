using CQRS_DOTNET_SAMPLE.API;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS_DOTNET_SAMPLE.ApplicationCore.Features.Tasks.Query
{
    public class GetAllMeetingQueryHandler : IRequestHandler<GetAllMeetingsQuery, IEnumerable<Meeting>>
    {
        private MeetingDbContext _dbContext;
        public GetAllMeetingQueryHandler(MeetingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Meeting>> Handle(GetAllMeetingsQuery request, CancellationToken cancellationToken)
        {
            var meetings = await _dbContext.Meetings.ToListAsync();
            return meetings;
        }
    }
}
