using BookStore.Model.Base;

namespace BookStore.DL.InMemoryDB
{
    public static class InMemoryDB
    {
        public static List<Author> Authors = new List<Author>()
        {
            new Author()
            {
                Id = 1,
                Name = "Pesho"
            },
            new Author()
            {
                Id = 2,
                Name = "Stamat"
            }
        };
    }
}
