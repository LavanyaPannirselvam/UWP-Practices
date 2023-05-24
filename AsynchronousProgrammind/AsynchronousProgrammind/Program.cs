// See https://aka.ms/new-console-template for more information

namespace AsynchronousProgramming
{
    class Program
    {
        static async void Main(string[] args)
        {
            Console.WriteLine("From main method.....");
            await CallExampleAsync();
            Console.WriteLine("Exit main method");
        }

        static async Task CallExampleAsync()
        {
            Console.WriteLine("From call method...");
            await ExampleAsync();
            Console.WriteLine("Exit call method");
        }
        static async Task ExampleAsync()
        {
            Console.WriteLine("From async method...");
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("Exit async method");
        }


}
}
    

