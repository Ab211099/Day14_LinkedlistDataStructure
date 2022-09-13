namespace DatastructureDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            UC8 list = new UC8();
            list.AddEnd(56);
            list.AddEnd(30);
            list.AddEnd(70);
            list.InserInBetween(40, 3);
            list.display();
          
        }
    }
}