public class Program
{
    private static int _counter = 0;
    public static void Main(string[] args)
    {
        // Birden çok thread tarafından _counter değişkenine atomic işlemler gerçekleştirilir
        for (int i = 0; i < 5; i++)
        {
            Thread thread = new Thread(IncrementCounter);
            thread.Start();
        }

        Console.WriteLine("Counter: " + _counter);
        Console.ReadLine();
    }

    static void IncrementCounter()
    {
        // _counter değişkenini atomic olarak artır
        Interlocked.Increment(ref _counter);
    }
}