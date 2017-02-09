using System;
using System.IO;

namespace _02.Line_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var text = File.ReadAllLines("input.txt");

            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("output.txt", $"{i + 1}. {text[i]}{Environment.NewLine}");
            }
        }
    }
}
