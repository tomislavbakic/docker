using SkiSchool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiSchool.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApiDbContext context)
        {
            context.Database.EnsureCreated();
            if(!context.Instructors.Any())
            {
                context.Instructors.Add(new Instructor("Petar","Ilic", "06444466","pilic","123"));
                context.SaveChanges();
            }
        }
    }
}
