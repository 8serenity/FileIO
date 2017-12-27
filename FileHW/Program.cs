using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHW
{
    /*
    1.	В файле записана непустая последовательность целых чисел, являющихся числами Фибоначчи.
    Приписать еще столько же чисел этой последовательности.
    

*/


    class Program
    {
        static void Main(string[] args)
        {
            List<int> fibonacciNumbersList = new List<int>();
            string[] fibonacciNumbers ;
            string[] newFibonacciNumbers ;
            string path = @"C:\FolderToWorkHW\Fibonacci.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                fibonacciNumbers = sr.ReadToEnd().Split(' ');
                newFibonacciNumbers = new string[fibonacciNumbers.Length];
                for (int i = 0; i < fibonacciNumbers.Length; i++)
                {
                    fibonacciNumbersList.Add(int.Parse(fibonacciNumbers[i]));
                }

                for (int i = 0; i < fibonacciNumbers.Length; i++)
                {
                    fibonacciNumbersList.Add(fibonacciNumbersList.Last() + fibonacciNumbersList[fibonacciNumbersList.Count - 2]);
                    newFibonacciNumbers[i] = fibonacciNumbersList.Last().ToString();
                }


                for (int i = 0; i < newFibonacciNumbers.Length; i++)
                {
                    Console.WriteLine(newFibonacciNumbers[i]);
                }
            }

            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                for(int i = 0; i < newFibonacciNumbers.Length; i++)
                {
                    sw.Write(' ');
                    sw.Write(newFibonacciNumbers[i]);
                }
            }
            Console.Read();
        }
    }
}
