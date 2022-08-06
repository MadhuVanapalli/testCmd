using System;
using System.Text;

namespace testCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Program obj = new Program();
            //obj.Reverse("MadhuVanapalli");
            //Console.WriteLine();
            obj.Pattern1(6);
            obj.Pattern2(6);
            obj.Pattern3(6);
            obj.Pattern4(6);
            obj.Pattern5(6);
        }

        private bool IsPalindrome(int num)
        {
            bool isValid = false;

            int rev = num % 10;
            num = num / 10;


            return isValid;
        }
        private void Reverse(string strVal)
        {
            StringBuilder sb = new StringBuilder();
            char[] charArray = strVal.ToCharArray();
            for (int i = charArray.Length; i > 0; i--)
            {
                sb.Append(charArray[i - 1]);
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sb.ToString().ToLower());
            Console.WriteLine(sb.ToString().ToUpper());
        }

        private void Pattern1(int num)
        {
            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        private void Pattern2(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private void Pattern3(int num)
        {
            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = num; k >=i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        private void Pattern4(int num)
        {
            for (int i = num; i >= 1; i--)
            {
                for (int j = num; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private void Pattern5(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = i; j < num; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < (i*2); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}
