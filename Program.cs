using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Підрахунок та запис кількості символів у кожному рядку:
            string[] lines = File.ReadAllLines("text.txt");

            int[] charCounts = lines.Select(line => line.Count(c => char.IsLetterOrDigit(c) || char.IsPunctuation(c))).ToArray();

            Console.WriteLine("Number of symbols in each line: ");
            foreach (int count in charCounts)
            {
                Console.WriteLine(count);
            }
            // Знайдення найдовшого та найкоротшого рядків:
            string shortestLine = lines.OrderBy(line => line.Length).FirstOrDefault();
            string longestLine = lines.OrderByDescending(line => line.Length).FirstOrDefault();

            Console.WriteLine(" Shortest line: " + shortestLine + " Lengh of the line: " + shortestLine.Length);
            Console.WriteLine(" Longest line: " + longestLine + " Lengh of the line: " + longestLine.Length);

            Console.WriteLine("");

            // Знайдення та виведення рядків, які містять слово "var":
            var linesWithVar = lines.Where(line => line.Contains("var")).ToList();
            foreach (string line in linesWithVar)
            {
                Console.WriteLine($" Lines that contain a word var : {line} ");
            }
        }
    }
}