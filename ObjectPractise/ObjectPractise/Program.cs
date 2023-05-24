// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;
abstract class Human
{
    string? name;
    int age;
    public string Name
    {
        get{ return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }    
    }
    public abstract void greet();
    public void display()
    {
        Console.WriteLine($"From human class /t {name} and {age}");
    }
    public void display( string session )
    {
        Console.WriteLine("Good " + session);
    }
}
class Men : Human
{
    bool emotions = false;
    public bool Emotions
    {
        get { return emotions; }
        set { emotions = value; }
    }
    public new  void display()
    {
        Console.WriteLine($"{Name} and {Age} and {emotions}");
    }
    public override void greet() { Console.WriteLine("Welcome by {0}", Name); }
}
class Test
{
    static void Main(string[] args)
    {
        //Human h1 = new Human();
        //h1.Name = "Lav";
        //h1.Age = 20;
        //h1.display();//calls display from human class
        Human m1 = new Men();//always base method will be executed if the derived method doesn't contain override keyword
        m1.Name = "Prithivi";
        m1.Age = 21;
        m1.display();//calls display from human class with or w/o virtual at human and new at men cls
        m1.display("morning");
        Men men = new Men();
        men.Name = "Prithivi Raj";
        men.Age = 21;
        //men.display();//calls display from men class 
        //Console.Write("Enter your name:".PadRight(25)+"{0}",men.Name);
        //string name = Console.ReadLine();
        /*Dictionary<int, string> list = new()
        {
            { 1, "l" },
            {2, "a" }
        };

        Console.WriteLine(IsChoiceAvailable(5, list));
        static bool IsChoiceAvailable(int choice, Dictionary<int, string> list)
        {
            foreach (int i in list.Keys)
            {
                if (choice == i)
                    return true;
            }
            return false;
        }*/
        string date = "04/05/2023";
        var splits = date.Split("/");
        Console.WriteLine(splits[2]);
    }

}
