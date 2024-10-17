using System;
/*14.        check no is automorphic or not
input n=25
  output Automorphic
as 25*25=625
*/

namespace PracticeExamples
{
    internal class Automorphic
    {
        static void Main(string[] args)
        {
            int num = 7;
            int sqr = num * num;
            int temp = num;
            int a = 1;
            while (num > 0)
            {
                a=a*10;
                num = num / 10;

            }
            if (sqr % a == temp)
            {
                Console.WriteLine("Automorphic Number");
            }
            else
            {
                Console.WriteLine("Not Automorphic Number");
            }

        }
    }
}
