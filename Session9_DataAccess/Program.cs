using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Session9_DataAccess.DataAccess;
using Session9_DataAccess.Models;

namespace Session9_DataAccess
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            //await new Program().InsertCourse();
            //await new Program().InsertProgramme();
            await new Program().UpdateProgramme();
        }

        private async Task UpdateProgramme()
        {
            using DBContext dbContext = new DBContext();

            IQueryable<Course> result = dbContext.Courses.Where(c => c.Id.Equals("DNP1"));

            Course dnp = await dbContext.Courses.FirstAsync(c => c.Id.Equals("DNP1"));

            Programme softwareProgramme = await dbContext.Programmes.Include(p => p.Courses)
                .FirstAsync(p => p.ShortName.Equals("Software"));
            
            softwareProgramme.Courses.Add(dnp);
            dbContext.Update(softwareProgramme);
            await dbContext.SaveChangesAsync();
        }

        private async Task InsertCourse()
        {
            Course DNP1 = new Course{
                Id = "DNP1",
               Name = "Internet technlogies, C# and .NET",
               Semester = 3,
               IsElective = false,
               ECTS = 5
                };

            using (DBContext dbContext = new DBContext())
            {
                await dbContext.Courses.AddAsync(DNP1);
                await dbContext.SaveChangesAsync();
            }
        }

        private async Task InsertProgramme()
        {
            Course SDJ2 = new Course
            {
                Id = "SDJ2",
                Name = "Software Development with Java and UML 2",
                Semester = 2,
                IsElective = false,
                ECTS = 10
            };
            Course GMD = new Course
            {
                Id = "GMD1",
                Name = "Game Development",
                Semester = 6,
                IsElective = true,
                ECTS = 5
            };
            List<Course> courses = new List<Course> {GMD, SDJ2};
            Programme software = new Programme
            {
                Location = "Horsens",
                Name = "Software Technology Engineering",
                ShortName = "Software",
                HeadOfDepartment = "AHM",
                Courses = courses
            };

            using (DBContext dbContext = new DBContext())
            {
                await dbContext.Programmes.AddAsync(software);
                await dbContext.SaveChangesAsync();
            }
        }
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}