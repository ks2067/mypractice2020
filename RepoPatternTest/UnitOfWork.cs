using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepoPatternTest.Data;
using RepoPatternTest.Repository;
using Microsoft.EntityFrameworkCore;

namespace RepoPatternTest
{
    public class UnitOfWork
    {
        private RepoContext repoContext;
        public UnitOfWork(RepoContext _repoContext)
        {
            this.repoContext = _repoContext;
            CourseRepository = new CourseRepository(this.repoContext);
            AuthorRepository = new AuthorRepository(this.repoContext);
        }
        public ICourseRepository CourseRepository { get; private set; }
        public IAuthorRepository AuthorRepository { get; private set; }

        public void Complete()
        {
            this.repoContext.SaveChanges();
        }
    }
}
