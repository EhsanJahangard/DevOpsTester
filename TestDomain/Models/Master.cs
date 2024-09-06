namespace TestDomain.Models;

public class Master : Common.BaseEntity<Guid>
{
   

    public Master(string name, string family, string? mobile, string? website, DateTime? dateBirth, string? degree, string? titleBio, string? bio, string? photo, byte? years_Experience)
    {
        Id = Guid.NewGuid();
        Name = name;
        Family = family;
        Mobile = mobile;
        Website = website;
        DateBirth = dateBirth;
        Degree = degree;
        TitleBio = titleBio;
        Bio = bio;
        Photo = photo;
        Years_Experience = years_Experience;
        
    }

    public string Name { get; set; }
    public string Family { get; set; }
    public string? Mobile { get; set; }
    public string? Website { get; set; }
    public DateTime? DateBirth { get; set; }
    public string? Degree { get; set; }
    public string? TitleBio { get; set; }
    public string? Bio { get; set; }
    public string? Photo { get; set; }
    public byte? Years_Experience { get; set; }
    public virtual ICollection<Test> Tests { get; set; }


}


