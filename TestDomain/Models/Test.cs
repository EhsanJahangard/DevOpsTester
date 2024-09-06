using System.ComponentModel.DataAnnotations;

namespace TestDomain.Models;

public class Test : Common.BaseEntityTitle<Guid>
{
    public Test(string title)
    {
        Title = title;
    }
    public DateTime? DateTest { get; set; } 
    public string Description { get; set; }
    [AllowedValues("OnSite", "Remote", "Other")]
    public string TypeTest { get; set; } = "Remote";
    public DateTime? ExpirtionTest { get; set; }
    public byte? LengthMinuteTest { get; set; } = 10;
    public Guid MasterId { get; set; }
    public Master Master { get; set; }
}


