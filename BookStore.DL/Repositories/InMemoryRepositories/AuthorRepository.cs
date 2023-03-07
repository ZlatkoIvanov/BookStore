using BookStore.DL.Interfaces;
using BookStore.Model.Base;


namespace BookStore.DL.Repositories.InMemoryRepositories
{
    public class AuthorInMemoryRepository : IAuthorRepository
    {
        public IEnumerable<Author> GetAll()
        {
            return InMemoryDB.InMemoryDB.Authors;
        }

        public Author GetById(int id)
        {
            return InMemoryDB.InMemoryDB
                .Authors.SingleOrDefault(x => x.Id == id);
        }

        public void Add(Author author)
        {
            InMemoryDB.InMemoryDB.Authors.Add(author);
        }
    }
}