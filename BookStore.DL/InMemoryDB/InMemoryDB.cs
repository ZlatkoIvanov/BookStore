using BookStore.Model.Base;

namespace BookStore.DL.InMemoryDB
{
    public class InMemoryDB
    {
        public List<Author>Authors = new List<Author> ()
        {
            new Author()
            {
                ID = 1,
                Name = "Pesho"
            }
            new Author()
            {
                ID = 2,
                Name = "Stamat"
            }      
        }
    }
}
