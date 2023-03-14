using BookStore.DL.Interfaces;

public class LibraryService : ILibraryService
{
    private readonly IAuthorRepository _authorRepository;
    private readonly IBookRepository _bookRepository;

    public LibraryService(IAuthorRepository authorRepository,
        IBookRepository bookRepository);
}
public GetAllBooksByAuthorResponse GetAllBooksByAuthorId(int)
{
    var author = _authorRepository.GetById()
}