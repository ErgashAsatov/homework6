namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\hello c#\gitignore";
            File.Create(path);
        }
    }
}