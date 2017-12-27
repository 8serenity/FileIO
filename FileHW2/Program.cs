using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHW2
{
    /*
    2.	Сложить два целых числа А и В.
    
    Входные данные
    В единственной строке входного файла INPUT.TXT записано два натуральных числа через пробел.
    
    Выходные данные
    В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — сумму чисел А и В.
         */


    class Program
    {
        static void Main(string[] args)
        {
            string pathToRead = @"C:\FolderToWorkHW\INPUT.txt";
            string pathToWrite = @"C:\FolderToWorkHW\OUTPUT.txt";
            string[] numbers;
            int sum = 0;

            using (StreamReader sr = new StreamReader(pathToRead))
            {
                numbers = sr.ReadToEnd().Split(' ');
                List<int> numbersList = new List<int>();
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbersList.Add(int.Parse(numbers[i]));
                    sum += numbersList.Last();
                }
            }

            using (StreamWriter sw = new StreamWriter(pathToWrite, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(sum);
            }



            Console.Read();
        }
    }
}
