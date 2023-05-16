// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static object _lockObject = new object();

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

        // Kritik bölüme erişmek için lock nesnesini kullanın
        lock (_lockObject)
        {
            try
            {
                Console.WriteLine("Thread {0} kritik bölüme girdi ve bazı işlemler gerçekleştiriyor.", threadId);
                Thread.Sleep(2000); // Biraz iş simülasyonu

                Console.WriteLine("Thread {0} kritik bölümden çıkıyor.", threadId);
            }
            finally
            {
                // Kilit nesnesini serbest bırakın
            }
        }
    }
}