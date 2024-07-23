using System.Net;

namespace InfrastructureService
{
    public class ResponseMessage 
    {
        public ResponseMessage()
        {
            Message = "عملیات با موفقیت انجام شد";
        }

        public ResponseMessage(object content)
        {
            Message = "عملیات با موفقیت انجام شد";
            Content = content;
        }

        public ResponseMessage(string message)
        {
            Message = message;
        }

        public ResponseMessage(string message, object content)
        {
            Message = message;
            Content = content;
            
        }

        public ResponseMessage(HttpStatusCode status)
        {
            Status = status;
        }

        public string Message { get; set; }
        public object Content { get; set; }
        public HttpStatusCode Status { get; set; } = HttpStatusCode.OK;
    }
}
