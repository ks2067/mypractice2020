using Microsoft.EntityFrameworkCore;
using RepoPatternTest.Data;
using RepoPatternTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoPatternTest.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(RepoContext repoContext) :base(repoContext)
        {

        }
        IEnumerable<Course> ICourseRepository.GetTopCourses(int count)
        {
            return RepoContext.Courses.Take(count);
        }
        public void SaveChanges()
        {
            Context.SaveChanges();
        }
        public RepoContext RepoContext
        {
            get { return Context as RepoContext; }
        }
    }
}
