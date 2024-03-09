namespace Task5;

public  class Statick<T>
{
    List<T> _lists=new List<T>();
    public void Push(T item)
    {
        _lists.Add(item);
        System.Console.WriteLine($"Elementi:{item} dokhil karda shud!");
    }
    public T Pop()
    {
        if (_lists.Count==0)
        {
            try
            {

            }
            catch (Exception)
            {
                System.Console.WriteLine("List kholi ast avval ba on element dokhil kuned!");
            }
        }
        
            
        return _lists[_lists.Count-1];
        _lists.RemoveAt(_lists.Count-1);
    }
    public T Peek()
    {
        if (_lists.Count==0)
        {
            try
            {

            }
            catch (Exception)
            {
                System.Console.WriteLine("List kholi ast avval ba on element dokhil kuned!");
            }
        }
        return _lists[_lists.Count-1];

    }

}
