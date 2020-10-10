using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RepoPatternTest.Repository;
using RepoPatternTest.Models;
using RepoPatternTest.Data;

namespace RepoPatternTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UnitOfWork uow = new UnitOfWork(new RepoContext());
            //ICourseRepository repo = new CourseRepository(new RepoContext());
            Course course = new Course { Name = "Free One", Description = "Free Course", Level = 1, FullPrice = 0, AuthorId = 3};
            uow.CourseRepository.Add(course);

            Author author = new Author { Name = "William Shakespeare" };
            uow.AuthorRepository.Add(author);

            uow.Complete();


            CreateWebHostBuilder(args).Build().Run();

            

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
