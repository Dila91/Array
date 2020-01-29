using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Operations
    {

         public static void printArray(int i, int j)
        {
            int[] Arrlon = new int[i];
            string[] Arrname = new string[j];
           
            
            for (int n = 0; n < Arrlon.Length; n++)
            {
                Console.Write("Input the employers name:");
                Arrname[n] = Console.ReadLine();
                Console.Write("Input the implojers  lon :");
                Arrlon[n] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("==============================================================");
            Console.WriteLine();
            Console.WriteLine("Employers Nam and Lon Tabell:");
           

            for (int n = 0; n < Arrlon.Length; n++)
            {

                Console.WriteLine(Arrname[n] + "\t" + Arrlon[n]);
                Console.WriteLine();

            }
            

         }
            
          
}
    }
