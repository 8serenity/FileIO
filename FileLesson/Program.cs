using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/*

Тема: Взаимодействие с файловой системой.

1.	Написать программу, читающую побайтно заданный файл и подсчитывающую число появлений каждого из 256 возможных знаков.
2.	С помощью класса StreamWriter записать в текстовый файл свое имя, фамилию и возраст. Каждая запись должна начинаться с новой строки.

 */


namespace FileLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fstream = File.OpenRead(@"C:\FolderToWork\FileToRead.txt"))
            {

                byte[] array = new byte[fstream.Length];

                fstream.Read(array, 0, array.Length);


                for (int i = 0; i < 255; i++)
                {
                    Console.Write("Code {0} ", i);
                    Console.Write("repeats ");
                    int numberRepeats = 0;
                    for(int j = 0; j < array.Length; j++)
                    {
                        if (i == array[j])
                        {
                            numberRepeats++;
                        }
                    }

                    Console.Write("{0} times", numberRepeats);
                    Console.WriteLine();
                }

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }



            }

            string stringToWrite;

            StringBuilder builderText = new StringBuilder();

            builderText.AppendLine("Niyaz");
            builderText.AppendLine("Mukhamedya");
            builderText.AppendLine("23");
            stringToWrite = builderText.ToString();

            using (FileStream fstream = new FileStream(@"C:\FolderToWork\FileToWrite.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(stringToWrite);
                fstream.Write(array, 0, array.Length);
            }

            Console.Read();
        }
    }
}
