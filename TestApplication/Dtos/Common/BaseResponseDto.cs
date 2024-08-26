using System.Net.NetworkInformation;
using System.Net;

namespace TestApplication.DTOs.Common
{
    public record BaseResponseDto
    {

        public object? Data { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string? Message { get; set; }
        public List<string> Errors { get; set; }
        public HttpStatusCode Status { get; set; } = HttpStatusCode.OK;
        public BaseResponseDto()
        {
            Message = "عملیات با موفقیت انجام شد";
        }

        public BaseResponseDto(object content)
        {
            Message = "عملیات با موفقیت انجام شد";
            Data = content;
        }

        public BaseResponseDto(string message)
        {
            Message = message;
        }

        public BaseResponseDto(string message, object content)
        {
            Message = message;
            Data = content;

        }

        public BaseResponseDto(HttpStatusCode status)
        {
            Status = status;
        }
        public BaseResponseDto(Exception ex)
        {
            Status = HttpStatusCode.InternalServerError;
            Message = "خطا پیش آمده";
            Errors.Add(ex.Message.ToString());
            IsSuccess = false;
        }
    }
}
