using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _03.Word_Count
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var text = File.ReadAllText("Text.txt")
                .ToLower()
                .Split(new[] { ' ', '\n', '\r', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            var words = File.ReadAllText("words.txt")
                .ToLower()
                .Split();

            var result = new Dictionary<string, int>();


            for (int i = 0; i < words.Length; i++)
            {
                var currWord = words[i];
                var currWordCount = 0;

                for (int j = 0; j < text.Length; j++)
                {
                    if (currWord == text[j])
                    {
                        currWordCount++;
                    }
                }
                result[currWord] = currWordCount; 
            }
            var sortedResult = result
                .OrderByDescending(kvp => kvp.Value)
                .Select(kvp => $"{kvp.Key} - {kvp.Value}")
                .ToArray();

            File.WriteAllLines("result.txt", sortedResult);
        }
    }
}
