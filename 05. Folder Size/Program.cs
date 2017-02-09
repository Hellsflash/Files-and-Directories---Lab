using System.IO;

namespace _05.Folder_Size
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var files = Directory.GetFiles("TestFolder");

            double sum = 0;

            foreach (var file in files)
            {
                FileInfo fileinfo = new FileInfo(file);
                sum += fileinfo.Length;
            }
            sum = sum / 1024 / 1024;

            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
