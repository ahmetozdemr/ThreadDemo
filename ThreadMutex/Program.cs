// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static Mutex _mutex = new Mutex();
    public static void Main(string[] args)
    {
        // Kritik bölüme aynı anda erişmek için birden çok thread oluşturun
        for (int i = 0; i < 5; i++)
        {
            Thread thread = new Thread(DoWork);
            thread.Start(i);
        }

        Console.ReadLine();
    }

    static void DoWork(object threadId)
    {
        Console.WriteLine("Thread {0} kritik bölüme girmeye çalışıyor.", threadId);

        // Mutex'in müsait olmasını bekleyin
        _mutex.WaitOne();

        try
        {
            Console.WriteLine("Thread {0} kritik bölüme girdi ve bazı işlemler gerçekleştiriyor.", threadId);
            Thread.Sleep(2000); // Biraz iş simülasyonu

            Console.WriteLine("Thread {0} kritik bölümden çıkıyor.", threadId);
        }
        finally
        {
            // Mutex'i serbest bırakın
            _mutex.ReleaseMutex();
        }
    }
}