namespace DatastructureDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            UC5 list = new UC5();
            list.AddEnd(56);
            list.AddEnd(30);
            list.AddEnd(70);
            list.DeleteFirstNode();
            list.display();
            
        }
    }
}