using Task6;

var book=new Book();

var library =new Library();
for ( ;;)
{
    System.Console.WriteLine("Add a Book, Display All Books,Update a Book,Delete a Book,Search by Title,Search by Author,Exit");
   
   var a=Console.ReadLine();
    if (a=="Add")
    {
        System.Console.WriteLine("Kitobro dokhil kuned:");
       Book book1= new Book()
        {
            Id=Convert.ToInt32(Console.ReadLine()),
            Titly=Console.ReadLine(),
            Author=Console.ReadLine()
        };
        library.AddBook(book1);
    }
    if (a=="Display")
    {
        System.Console.WriteLine("Ruykhati kitobho");
       foreach (var item in library.DisplayBook())
       {
            System.Console.WriteLine("ID:"+item.Id);
            System.Console.WriteLine("Titly"+item.Titly);
            System.Console.WriteLine("Author"+item.Author);
       }
    }
    if (a=="Update")
    {
        System.Console.WriteLine("Kitobro ivaz namoed");
       new Book()
        {
            Id=Convert.ToInt32(Console.ReadLine()),
            Titly=Console.ReadLine(),
            Author=Console.ReadLine()
        };
        
       library.UpdateBook(library);
    }
    if (a=="Delete")
    {
        library.DeleteBook( Convert.ToInt32(Console.ReadLine()));
    }
    if (a=="Search by Title")
    {
        
    }
        if (a=="Search by Author")
    {
        
    }
    if (a=="Exit")
    {
        return 0;
    }

}