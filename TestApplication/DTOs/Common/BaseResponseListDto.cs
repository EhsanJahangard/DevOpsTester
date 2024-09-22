namespace TestApplication.DTOs.Common;

public class BaseResponseListDto<T>
{
    public BaseResponseListDto(T id, string title)
    {
        Id = id;
        Title = title;
    }

    public T Id { get; set; }
    public string Title { get; set; }
}
