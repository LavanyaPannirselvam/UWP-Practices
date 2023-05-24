namespace AsynchronousProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute();
            Console.WriteLine("bye");
            Console.ReadKey();
        }
        static async void Execute()
        {
            int t = await Calculate(10, 20);
            Console.WriteLine(t);
            Console.WriteLine("done");

        }
        static async Task<int> Calculate(int x, int y)
        {
            Console.WriteLine("start");
            await Task.Delay(4000);
            Console.WriteLine("End");
            return x + y;
        }
    }
}

