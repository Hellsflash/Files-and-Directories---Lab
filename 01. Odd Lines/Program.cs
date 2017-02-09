using System;
using System.IO;

namespace _01.Odd_Lines
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var text = File.ReadAllLines("input.txt");

            for (int i = 1; i < text.Length; i+=2)
            {
                File.AppendAllText("output.txt", text[i] + Environment.NewLine);
            }
        }
    }
}
