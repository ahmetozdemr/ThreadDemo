// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static async Task Main(string[] args)
    {
        LongProcess();
        ShortyProcess();

        Console.ReadKey();
    }

    static async void LongProcess()
    {
        Console.WriteLine("LongProcess Started");
        await Task.Delay(4000);
        Console.WriteLine("LongProcess Completed");
    }

    static async void ShortyProcess()
    {
        Console.WriteLine("ShortProcess Started");

        Console.WriteLine("ShortProcess Completed");
    }
}
