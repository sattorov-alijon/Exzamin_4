namespace Task6;

public class Library : Book,ILibrary
{
    List<Book> _list=new List<Book>();
    public void AddBook(Book book)
    {
            _list.Add(book);
    }
    public List<Book> DisplayBook()
    {
        return _list;
    }
    public void UpdateBook(Book book)
    {
            
        if (book.Id==Id)
        {
            Titly=book.Titly;
            Author=book.Author;
        }
        else
        {
            try
            {
                
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("In guna Id nest");
            }
        }
    }

    public void DeleteBook(int id)
    {
        if (id==Id)
        {
            _list.RemoveAt(id);
        }
        else
        {
            try
            {
                
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("In guna Id nest");
            }
        }
    }

    public void AddBook()
    {
        throw new NotImplementedException();
    }

    public void UpdateBook()
    {
        throw new NotImplementedException();
    }

    public void DeleteBook()
    {
        throw new NotImplementedException();
    }

    public List<Book> SearchByTitle()
    {
        throw new NotImplementedException();
    }

    public List<Book> SearchByAuthor()
    {
        throw new NotImplementedException();
    }
}
