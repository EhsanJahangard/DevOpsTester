using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.DTOs.Person;

    public record GetPersonListDto(string PersonId, string Name,string Family,DateTime Age , string Mobile);
   
   

