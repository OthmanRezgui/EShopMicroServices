public class GenericList<T>
{
    public T Book { get; set; }
    public List<T> List { get; set; } = new List<T>();

    public void Add(T book)
    {
        List.Add(book);
    }

    public U Max<U>(U a, U b) where U : IComparable
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    public T GetFirst()
    {
        return List[0];
    }

    public void Test()
    {
        var book = new GenericList<string>();
        book.Add("chagnababnda");
    }
}


