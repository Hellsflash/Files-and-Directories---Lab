using System;
using System.Linq;
using System.IO;
namespace _04.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = File.ReadAllText("FileOne.Txt")
                .Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var second = File.ReadAllText("FileTwo.Txt")
                .Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            File.WriteAllText("result.txt", "");

            for (int i = 0; i < first.Length; i++)

            {

                File.AppendAllText("result.txt", first[i] + "\r\n" + second[i]+ "\r\n");

            }




        }
    }
}
