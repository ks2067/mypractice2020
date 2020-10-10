using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepoPatternTest.Models;

namespace RepoPatternTest.Repository
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTopCourses(int autherId);
        void SaveChanges();
    }
}
