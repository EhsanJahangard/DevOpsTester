using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPersistence.Contexts;

public class DevOpsTesterContext : DbContext
{
    public DevOpsTesterContext(DbContextOptions<DevOpsTesterContext> options)
     : base(options)
    {

    }
}
