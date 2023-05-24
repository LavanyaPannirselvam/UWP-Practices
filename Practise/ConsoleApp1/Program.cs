using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;

namespace ConsoleApp1
{
    /*class Program
    {

        delegate int Sample(int x, int y);
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Sub(int x)
        {
            return 100 - x;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //string? name=Console.ReadLine();
            //Console.WriteLine("Welcome "+name);->to get name and print
            int num1, num2, temp=0;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            //int? sum = num1 + num2;
            //float? remainder = num1 / num2;
            Console.WriteLine("Before swapping: {0} , {1}",num1,num2);
            // int num3 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After swapping: {num1} , {num2}");

            //Console.WriteLine(num1*num2*num3);
            Sample s1 = Add;
            // Sample s2 = Sub;
            Func<int, int, int> f = Add;
            Console.WriteLine(f.Invoke(10,2));

           // Console.WriteLine(s1.Invoke(10, 20));
           // Console.WriteLine(s2(100, 20));
           List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            Console.WriteLine($"List count : {list.Count()}");
            list.Remove(1);
            Console.WriteLine("List items");
            foreach(int x in list) { Console.WriteLine(x); }*/
    class Program
    {
        static void Main()
        {
            string date = "05/07/2002";
            DateOnly startDate = DateOnly.Parse(DateTime.ParseExact(date!, "mm/dd/yyyy", CultureInfo.InvariantCulture).ToShortDateString());
            DateOnly endDate = new DateOnly(2001, 05, 24);
            Console.WriteLine(startDate);
            if (startDate <= endDate)
                Console.WriteLine("good");
            else Console.WriteLine("bad");

        }
    }


}

