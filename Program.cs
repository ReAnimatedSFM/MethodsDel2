using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDel2
{
    class Program
    {
        /*
        private static int[] Generate(int a) //1 - 100
        {
            Random rndNumber = new Random();
            int[] heltTalsArray = new int[a];

            for (int i = 0; i < heltTalsArray.Length; i++)
            {
                heltTalsArray[i] = rndNumber.Next(0, 101);
            }

            return heltTalsArray;
        }
        */

        
        private static int[] Generate(int a) // -int32 til +int32
        {
            Random rndNumber = new Random();
            int[] heltTalsArray = new int[a];

            for (int i = 0; i < heltTalsArray.Length; i++)
            {
                heltTalsArray[i] = rndNumber.Next();
            }

            return heltTalsArray;
        }
        

        private static void Print(int[] tempArray)
        {
            for (int i = 0; i < tempArray.Length; i++)
            {
                Console.WriteLine("Index" + i +  ": " + tempArray[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] a = Generate(10);
            Print(a);
            Console.ReadKey();
        }
    }
}
