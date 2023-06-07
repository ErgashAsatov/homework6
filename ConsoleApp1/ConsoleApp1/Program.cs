using Microsoft.VisualBasic.FileIO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\hello c#\new folder\folders\";
            string[] folders = { "bin", "obj","sfsafsd" };

            foreach (string folder in folders)
            {
                string folderPath = Path.Combine(path, folder);
                if (Directory.Exists(folderPath))
                {
                    Directory.Delete(folderPath, true);
                    Console.WriteLine("folderPath is deleting");
                }
                else
                {
                    Console.WriteLine("there are no folders which you search");
                }
            }
         
            
            
           
            
        }
        
        
    }
}