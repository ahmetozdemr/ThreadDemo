// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {

        Thread x = new Thread(() => {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("X");
            }
        });

        x.Start();
        x.Join();

        new Thread(() => {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("Y");
            }
        }).Start();


        Console.WriteLine("Z");

        Console.ReadKey();
    }
}