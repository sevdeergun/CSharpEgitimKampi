using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopWithStarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 tane yıldız oluşturma
            //for (int i = 0; i < 10; i++)  
            //{
            //   Console.WriteLine("*");
            //}
            #endregion

            #region dik üçgen oluşturma
            //for (int i = 1; i <= 5; i++)
            //{
            //     for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //  }
            #endregion

            #region ters dik üçgen oluşturma
            //for (int i = 5; i>= 1; i--)
            //{
            //    for (int j =1; j<=i; j++)
            //    {
            //        console.write("*");
            //    }
            //    console.writeline();

            //}
            #endregion

            #region baklava dilimi
            //int n = 5;

            // Üst kısım (Üçgen)
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            // Alt kısım (Ters Üçgen)
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    //boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit

            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                //boşluklar
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                //yıldızlar
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();
        }

    }
   
}
