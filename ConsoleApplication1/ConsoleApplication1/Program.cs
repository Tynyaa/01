using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество рек: ");
            int count = Convert.ToInt32(Console.ReadLine());
            River[] arrayRiver = new River[count];
            for (int i = 0; i < arrayRiver.Length; i++)
            {
                arrayRiver[i] = new River();
                arrayRiver[i].Fill();
            }

            Console.WriteLine();
            for (int i = 0; i < arrayRiver.Length; i++)
                Console.WriteLine(arrayRiver[i].ToString());


            Console.ReadKey();
        }
    }
}
