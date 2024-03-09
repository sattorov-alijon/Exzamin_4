namespace Task6;

public interface ILibrary
{
  
     void AddBook();
    List<Book> DisplayBook();
     void UpdateBook();
     void DeleteBook();
    List<Book> SearchByTitle();
     List<Book> SearchByAuthor();
}
