// See https://aka.ms/new-console-template for more information

internal class Program
{
    static List<string> _list = new List<string>();
    public static void Main(string[] args)
    {

        new Thread(AddItem).Start();
        new Thread(AddItem).Start();


        Console.ReadKey();
    }

    static void AddItem()
    {
        lock (_list) _list.Add("Item " + _list.Count);

        string[] items;
        lock (_list) items = _list.ToArray();
        foreach (string s in items) Console.WriteLine(s);
    }
}