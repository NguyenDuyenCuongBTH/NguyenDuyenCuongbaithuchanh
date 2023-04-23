using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaiThucHanh1704.Models;
using DemoMVC.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BaiThucHanh1704.Models.Faculty> Faculty { get; set; } = default!;

        public DbSet<DemoMVC.Models.Student> Student { get; set; } = default!;
    }
