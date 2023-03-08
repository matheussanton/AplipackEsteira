using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteAplipack.Domain.Box.Models;

namespace TesteAplipack.Host.Context
{
    public class ApiDbContext : DbContext
    {
        public DbSet<BoxModel> Boxes { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}
