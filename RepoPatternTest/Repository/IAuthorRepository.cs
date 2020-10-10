using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepoPatternTest.Models;

namespace RepoPatternTest.Repository
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetTopAuthors(int count);
        void SaveChanges();
    }
}
