using Microsoft.EntityFrameworkCore;
using RepoPatternTest.Data;
using RepoPatternTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoPatternTest.Repository
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(RepoContext repoContext) :base(repoContext)
        {
        }
        IEnumerable<Author> IAuthorRepository.GetTopAuthors(int count)
        {
            return RepoContext.Authors.Take(count);
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
