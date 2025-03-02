using CQRS_DOTNET_SAMPLE.API;
using MediatR;

namespace CQRS_DOTNET_SAMPLE.ApplicationCore.Features.Tasks.Query
{
    public class GetAllMeetingsQuery : IRequest<IEnumerable<Meeting>>
    {

    }
}
