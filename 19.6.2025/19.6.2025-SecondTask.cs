using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._6._2025
{
    internal class _19
    {
        static void Main(string[] args)
        {
            string student = Console.ReadLine();
            Console.WriteLine($"{student} -> ");
            string book = Console.ReadLine();

            Dictionary<string, List<string>> studentBooks = new Dictionary<string, List<string>>();

            while (student != "end")
            {
                student = Console.ReadLine();
                Console.WriteLine($"{student} -> ");
                book = Console.ReadLine();

                if (studentBooks.ContainsKey(student))
                {
                    studentBooks[student].Add(book);
                }
                else
                {
                    studentBooks[student] = new List<string> { book };
                }

            }

            foreach (var entry in book)
            {
                Console.WriteLine($"{entry}: {book}");
            }
        }
    }
}
