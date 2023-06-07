namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string path = @"D:\hello c#";
            string[] bins = Directory.GetDirectories(path, "bin*");
            foreach (string bin in bins)
            {
                Console.WriteLine(bin);
            }
            Console.WriteLine("-----------");
            string[] objs = Directory.GetDirectories(path, "obj*");
            foreach (string obj in objs)
            {
                Console.WriteLine(obj);
            }
        }
    }
}