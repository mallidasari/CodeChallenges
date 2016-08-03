using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Sequence : ");

            string input = Console.ReadLine();

            if (!String.IsNullOrEmpty(input))
            {
                string[] arr = input.Split(' ');

                int[] arrInts = Array.ConvertAll(arr, int.Parse);

                bool status = checkStatus(arrInts);

                Console.WriteLine("Test Case for Given Sequence : " + (status ? "PASSED" : "FAILED"));
            }

        }
        //Complextity : O(n)

        public static bool checkStatus(int[] inputs)
        {
            var len = inputs.Length;
            int sum = inputs.Sum(),
                leftSum = 0,
                i;
            if (len > 2)
            {
                for (i = 0; i < len; i++)
                {
                    sum -= inputs[i];

                    if (leftSum == sum)
                    {
                        return true;
                    }

                    leftSum += inputs[i];

                }
            }

            return false;

        }
    }
}
