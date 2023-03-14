using BookStore.Models.Responses;

namespce BookStore.BL.Interfaces
    
    public interface ILibraryService
{
    GetAllBooksByAuthorResponse
        GetAllBooksByAuthorId(int authorId);
}