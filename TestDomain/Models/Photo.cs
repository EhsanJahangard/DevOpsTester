namespace TestDomain.Models;

public class Photo : Common.BaseEntityTitle<Guid>
{
    public virtual ICollection<QuestionPhoto> QuestionPhotos { get; set; }
    public Photo(string title)
    {
        Id = Guid.NewGuid();
        Title = title;
    }
}
