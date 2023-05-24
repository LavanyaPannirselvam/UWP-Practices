//namespace AsynchronousProgramming
//{
//    class Program
//    {
//        public static async Task Main(string[] args)
//        {
//            Console.WriteLine("start");
//            CancellationTokenSource cts = new(5000);
//            CancellationToken cancellationToken = cts.Token;
//            try
//            {
//                await Task.Run(async () =>
//                {
//                    int i = 1;
//                    Console.WriteLine(i++);
//                    await Task.Delay(1000);
//                    if(cancellationToken.IsCancellationRequested)
//                    {
//                        throw new OperationCanceledException();
//                    }

//                },
//                cancellationToken);
//            }
//            catch(OperationCanceledException)
//            {
//                Console.WriteLine("task cancelled");
//            }
//            //cts.Cancel();
//        }


//        //public static void Main(string[] args)
//        //{
//        //    Console.WriteLine("Main Method Started......");
//        //    SomeMethod();
//        //    Console.WriteLine("Main Method End");
//        //    Console.ReadKey();
//        //}
//        //public async static void SomeMethod()
//        //{
//        //    Console.WriteLine("Some Method Started......");
//        //    await Wait();
//        //    Console.WriteLine("Some Method End");
//        //}
//        //private static async Task Wait()
//        //{
//        //    await Task.Delay(TimeSpan.FromSeconds(10));
//        //    Console.WriteLine("\n10 Seconds wait Completed\n");
//        //}
//    }
//}

