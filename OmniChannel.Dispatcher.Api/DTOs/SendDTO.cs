namespace OmniChannel.Dispatcher.Api.DTOs
{
    public record SendDTO
    {
        public string Channel {  get; set; } = String.Empty;
        public string Message {  get; set; } = String.Empty;
    }
}
