using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_to_Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberToWords words = new NumberToWords();
            string word = "";

            int min = 0;
            int max = 0;
            int count = 0;

            Console.WriteLine("Min: ");
            min = int.Parse(Console.ReadLine());

            Console.WriteLine("Max: ");
            max = int.Parse(Console.ReadLine());

            var numberList = new List<int>();

            for (int i = min; i <= max; i++)
            {
                numberList.Add(i);
            }

             foreach (var item in numberList)
                {
                string nextWord = words.Convert(item);

                count += nextWord.Length;
                
                //word += nextWord;

                }



            Console.WriteLine(count);

           // Console.Write($"NtLC: {word.Length}");

            Console.ReadKey();


        }

    }
}
