using System;


namespace LottoKuppon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lav en eller anden form for menu til at vælge om du vil have lavet en kuppon eller noget andet(??????)
            Console.WriteLine("     Lotto " + DateTime.Now.ToString("dd.MM.yyy"));
            Console.WriteLine();
            Console.WriteLine("           1-uge");
            Console.WriteLine("         LYN-LOTTO");
            Console.WriteLine();

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(" " + i + ".  " + CreateRow());
            }

            Console.WriteLine("10.  " + CreateRow());

            Console.ReadKey();
        }

        public static string CreateRow()
        {
            string row = "";
            int[] rowArray = new int[7];

            for (int i = 0; i < 7; i++)
            {
                Random randomNumber = new Random();
                int number = randomNumber.Next(1, 37);
                int foundResult = Array.IndexOf(rowArray, number);

                if (foundResult < 0)
                {
                    rowArray[i] = number;
                }
                else
                {
                    //DET EN OMMER!
                    i--;
                }
            }
            Array.Sort(rowArray);

            foreach (int number in rowArray)
            {
                row += number.Format("D2");
            }
            return row;
        }
    }
}

