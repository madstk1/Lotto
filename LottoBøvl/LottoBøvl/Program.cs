using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoBøvl
{
    class Program
    {
        public int[] coupon;

        static void Main(string[] args)
        {
            //Lav en eller anden form for menu til at vælge om du vil have lavet en kuppon eller noget andet(??????)
            Console.WriteLine("Lotto " + DateTime.Now.ToString("dd.MM.yyy"));


            //Console.WriteLine(NumberGenerator());
            Console.WriteLine(CreateRow());

            Console.ReadKey();
        }


        public static string CreateRow()
        {
            string row = "";
            int[] rowArray = new int[7];
            Random randomNumber = new Random();

            for (int i = 0; i < 7; i++)
            {
                int number = randomNumber.Next(1, 37);
                int foundResult = Array.IndexOf(rowArray, number);

                if (foundResult < 0)
                {
                    rowArray[i] = number;
                }
                else
                {
                    i--;
                }
            }
            Array.Sort(rowArray);

            foreach (var item in rowArray)
            {
                row += (item + " ");
            }

            return row;
        }
    }
}
