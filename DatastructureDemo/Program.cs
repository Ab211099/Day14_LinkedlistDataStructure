namespace DatastructureDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            UC3 list = new UC3();

            list.AddEnd(56);
            list.AddEnd(30);
            list.AddEnd(70);
            list.display();
        }
    }
}