using Microsoft.EntityFrameworkCore;
using SkiSchool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiSchool
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        //modeli iz baze podataka
        public DbSet<Instructor> Instructors { get; set; }
    }
}
