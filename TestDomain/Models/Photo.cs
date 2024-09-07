namespace TestDomain.Models;

public class Photo : Common.BaseEntityTitle<Guid>
{
    
    public Photo(string title)
    {
        Id = Guid.NewGuid();
        Title = title;
    }
    public string Url { get; set; }
    public virtual ICollection<QuestionPhoto> QuestionPhotos { get; set; }

}
