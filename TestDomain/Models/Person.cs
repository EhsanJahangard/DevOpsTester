namespace TestDomain.Models;

public class Person : Common.BaseEntity<Guid>
{
    public string Name { get; set; }
    public string Family { get; set; }
    public DateTime DateBirth { get; set; }
    public string Mobile { get; set; }
    public string? Photo { get; set; }
    public string? CodeMeli { get; set; }
    public virtual ICollection<PersonSkill> PersonSkills { get; set; }
    public Person(string name, string family, DateTime dateBirth, string mobile)
    {
        Name = name;
        Family = family;
        DateBirth = dateBirth;
        Mobile = mobile;
    }
}
