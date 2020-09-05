using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyRota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRota.Data
{
    public interface IDbContextFactory<TContext> where TContext : IdentityDbContext<Employee>
    {
        TContext CreateDbContext();
    }
}
