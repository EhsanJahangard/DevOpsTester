namespace TestDomain.Models;

public class Person : Common.BaseEntity<Guid>
{
    public string Name { get; set; }    
    public string Family { get; set; }    
    public DateTime Age { get; set; }    
    public string Mobile { get; set; }    
}
