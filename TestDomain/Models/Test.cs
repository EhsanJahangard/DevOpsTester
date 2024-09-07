using System.ComponentModel.DataAnnotations;

namespace TestDomain.Models;

public class Test : Common.BaseEntityTitle<Guid>
{
    public Test()
    {
        Title = "---";
    }

    public Test( string title,  DateTime? dateTest, string description, string typeTest, DateTime? expirtionTest, byte? lengthMinuteTest, Guid masterId)
    {
        Title = title;
        DateTest = dateTest;
        Description = description;
        TypeTest = typeTest;
        ExpirtionTest = expirtionTest;
        LengthMinuteTest = lengthMinuteTest;
        MasterId = masterId;
       
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


