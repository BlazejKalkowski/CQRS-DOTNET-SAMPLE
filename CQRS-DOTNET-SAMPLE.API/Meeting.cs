namespace CQRS_DOTNET_SAMPLE.API
{
    public class Meeting
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Priority { get; set; }
        public DateTimeOffset From { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset To { get; set; } = DateTimeOffset.Now;
    }
}
