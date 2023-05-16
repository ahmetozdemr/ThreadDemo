// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        Thread y = new Thread(WriteY);
        y.Start();
        Thread z = new Thread(WriteZ);
        z.Start();

        for (int i = 0; i < 1000; i++)
        {
            Console.Write("X");
        }

        Console.ReadKey();
    }

    static void WriteY()
    {
        for (int i = 0; i < 1000; i++)
        {
            Console.Write("Y");
        }
    }

    static void WriteZ()
    {
        for (int i = 0; i < 1000; i++)
        {
            Console.Write("Z");
        }

    }
}