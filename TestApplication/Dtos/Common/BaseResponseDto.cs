namespace TestApplication.Dtos.Common
{
    public class BaseResponseDto
    {
        public object? Data { get; set; }
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public List<string> Errors { get; set; }
    }
}
