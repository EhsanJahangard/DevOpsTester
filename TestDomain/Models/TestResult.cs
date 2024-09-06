using System.ComponentModel.DataAnnotations;

namespace TestDomain.Models;

//
public class TestResult : Common.BaseEntity<Guid>
{
    public Guid PersonId { get; set; }
    public Person People { get; set; }
    public DateTime DateExam { get; set; }
    public Guid TestId { get; set; }
    public Test Test { get; set; }
    [MaxLength(5)]
    public string Grade { get; set;}
    [MaxLength(150)]
    public string Description { get; set;}

}
