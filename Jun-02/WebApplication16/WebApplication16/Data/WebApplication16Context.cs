using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication16.Models;

namespace WebApplication16.Data
{
    public class WebApplication16Context : DbContext
    {
        public WebApplication16Context (DbContextOptions<WebApplication16Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication16.Models.Student> Student { get; set; } = default!;
    }
}
