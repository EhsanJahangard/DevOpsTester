namespace TestDomain.Models;

public class Master : Common.BaseEntity<Guid>
{
    public Master() { }
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


