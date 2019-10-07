﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printAlphabelt
{
    class Program
    {
        static void Main(string[] args)
        {
            //printUppercase();
            //Console.WriteLine();
            //printLowercase();
            //Console.WriteLine();
            //codeASCII('b');
            //checkUPorLow('Y');
            //change('a');
            //Console.Write("Nhap mot so bat ky: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //IsPalindrome(number);
            //Console.WriteLine("nha^.p do^. da`i day~ so^' ");
            //int lenght = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[lenght];
            //CreatedArray(array);
            //CheckMinMax(array);
            Console.WriteLine("Write the string want to be upper : ");
            string str = Convert.ToString(Console.ReadLine());
            ChangeStrUP(str);//WE CAN USE THE METHOD : string str = "abcd", string upstr = str.ToUpper();
            Console.WriteLine("Write the string want to be lower : ");
            string str1 = Convert.ToString(Console.ReadLine());
            ChangeStrlower(str1);//WE CAN USE THE METHOD : string str = "abcd", string upstr = str.ToLower();
        }
        public static void printUppercase()
        {
            //uppercase 
            for (int i = 65; i <= 90; i++)
            {
                Console.Write(" " + (char)i);

            }
        }
        public static void printLowercase()
        {
            //lowercase
            for (int i = 97; i <= 122; i++)
            {

                Console.Write(" " + (char)i);

            }
        }
        static void codeASCII(char c)
        {
            for (int i = 65; i <= 122; i++)
            {
                if ((int)c == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void checkUPorLow(char c)
        {
            for (int i = 65; i <= 90; i++)
            {
                if ((int)c == i)
                {
                    Console.WriteLine("{0} is UPPERCASE", c);
                }
            }
            for (int j = 97; j <= 122; j++)
            {
                if ((int)c == j)
                {
                    Console.WriteLine("{0} is LOWERCASE", c);
                }
            }
        }
        static void change(char c)
        {
            int temp = 0;
            for (int i = 97; i <= 122; i++)
            {
                if ((int)c == i)
                {
                    temp = i - 32;
                }
            }
            Console.WriteLine("{0} change to uppercase", (char)temp);
        }
        static int IsPalindrome(int number)
        {
            int temp, remainder, sum = 0;
            if (number <= 10)
            {
                Console.WriteLine("So {0} khong phai la so doi xung (so palindrome)", number);
                return number;
            }
            for (temp = number; number != 0; number = number / 10)
            {
                remainder = number % 10;
                sum = sum * 10 + remainder;
            }
            if (temp == sum)
            {
                Console.WriteLine("So {0} la so doi xung (so palindrome)", temp);
            }
            else
            {
                Console.WriteLine("So {0} khong phai la so doi xung (so palindrome)", temp);
            }
            return temp;
        }
        static void CreatedArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Array[{0}] = ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
        public static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static void CheckMinMax(int[] array)
        {
            Console.WriteLine("{0} is Min of the array", Min(array));
            Console.WriteLine("{0} is Max of the array", Max(array));

        }
        static void ChangeStrUP(string str)
        {
            int temp ;
            string upper = "";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 97; j <= 122; j++)
                {
                    if (str[i] == j)
                    {
                        temp = j - 32;
                        upper += (char)temp;
                    }
                }

            }
            Console.Write(upper);
            Console.WriteLine();
        }
        static void ChangeStrlower(string str1)
        {
            int temp;
            string lower = "";
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 65; j <= 90; j++)
                {
                    if (str1[i] == j)
                    {
                        temp = j + 32;
                        lower += (char)temp;
                    }
                }

            }
          
            Console.Write(lower);
            Console.WriteLine();
        }
            
    }
}
