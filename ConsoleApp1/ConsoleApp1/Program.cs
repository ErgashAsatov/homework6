namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\hello c#";
            string[] fullnames = Directory.GetFiles(path,"*.txt");
                foreach (string fullname in fullnames)
                {
                    Console.WriteLine(fullname);
                }
           
        }
    }
}