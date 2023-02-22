using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10hw
{
    delegate int CountInArr(int[] arr);
    internal class Program
    {

        delegate int[] AnalyseRGB(string color);
        static void Main(string[] args)
        {
            AnalyseRGB analyseRGB = delegate (string color)
            {
                Color col = Color.FromName(color);
                int[] Code =new int[3] {col.R, col.G, col.B};
                return Code;
            };
            foreach(var i in analyseRGB("blue"))
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();

            CountInArr CountDiv7 = arr =>
            {
                int count = 0;
                for (int i=0; i < arr.Length; i++)
                {
                    if (arr[i] % 7 == 0) count++;
                }
                return count;
            };

            CountInArr CountPositive = arr =>
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0) count++;
                }
                return count;
            };

            CountInArr CountUniqNegative = arr =>
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                    {
                        int repeats = 0;
                        for(int j=i; j<arr.Length; j++)
                        {
                            if(arr[j] == arr[i]) repeats++;
                        }
                        if(repeats == 1) count++;
                    }
                }
                return count;
            };


            Console.ReadKey();
        }
    }
}
