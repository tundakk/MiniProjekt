using AuthorBook.Services.Models;
using System.Collections.Generic;

namespace AuthorBook.Services
{
    public interface IAuthorService
    {
        List<Author> GetAllAuthors();
    }
    public class AuthorService : IAuthorService
    {
        public List<Author> GetAllAuthors()
        {
            return new List<Author>
            {
                new Author(){AuthorId=1,Age=12,IsAlive=true,Name="Signe",Password="1234" },
                new Author(){AuthorId=2,Age=83,IsAlive=false,Name="Hans",Password="1234" },
            };
        }
    }
}
