using Microsoft.AspNetCore.Components.Web;

namespace TestDomain.Models;

public class Photo : Common.BaseEntityTitle<Guid>
{
    
    public Photo(string title,string url)
    {
        Id = Guid.NewGuid();
        Title = title;
        Url = url;
    }
    public string Url { get; set; }
    public virtual ICollection<QuestionPhoto> QuestionPhotos { get; set; }

}
