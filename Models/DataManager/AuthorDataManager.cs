using System.Collections.Generic;
using System.Linq;
using EFCoreDatabaseFirstSample.Models.DTO;
using EFCoreDatabaseFirstSample.Models.Repository;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDatabaseFirstSample.Models.DataManager
{
    public class AuthorDataManager : IDataRepository<Author, AuthorDto>
    {
        readonly BookStoreContext _bookStoreContext;

        public AuthorDataManager(BookStoreContext storeContext)
        {
            _bookStoreContext = storeContext;
        }

        public void Add(Author entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Author entity)
        {
            throw new NotImplementedException();
        }

        public Author Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAll()
        {
            return _bookStoreContext.Author
                .Include(author => author.AuthorContact)
                .ToList();
        }

        public AuthorDto GetDto(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Author entityToUpdate, Author entity)
        {
            throw new NotImplementedException();
        }
    }
}