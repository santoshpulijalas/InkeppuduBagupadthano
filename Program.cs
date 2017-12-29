using System;

namespace LeftArrayRotation
{
    class Program
    {
        static void Main(String[] args)
        {
                Console.WriteLine("Enter array length and number of left rotations you must perform:");
                string[] sizeAndNumber = Console.ReadLine().Split(' ');
                int s = Convert.ToInt32(sizeAndNumber[0]);
                int n = Convert.ToInt32(sizeAndNumber[1]);
                int i;
                Console.WriteLine("Enter array elements: ");
                string[] arrayInput = Console.ReadLine().Split(' ');
                int[] intArrayInput = Array.ConvertAll(arrayInput, int.Parse);

                if (n % s > 0) //Check if array size and rotation count is not same. If it's same then no need of rotating.
                {
                    int[] temp = new int[s];
                    for (i = 0; i < s - (n % s); i++)
                    {
                        temp[i] = intArrayInput[(n % s) + i];
                    }

                    for (i = 0; i < (n % s); i++)
                    {
                        temp[s - (n % s) + i] = intArrayInput[i];
                    }

                    intArrayInput = temp;
                }
                Console.WriteLine(string.Join(" ", intArrayInput));
                Console.ReadKey();            
        }
    }
}
