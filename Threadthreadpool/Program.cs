public class Program
{
    public static void Main(string[] args)
    {
        // ThreadPool'da çalıştırılacak iş parçacığı görevleri oluşturun
        for (int i = 0; i < 5; i++)
        {
            ThreadPool.QueueUserWorkItem(DoWork, i);
        }

        Console.ReadLine();
    }

    static void DoWork(object state)
    {
        Console.WriteLine("Thread {0} is performing some work.", state);
        Thread.Sleep(2000); // Biraz iş simülasyonu
        Console.WriteLine("Thread {0} has completed its work.", state);
    }
}