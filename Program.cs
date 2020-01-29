using System;

namespace Array
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Operations arr1 = new Operations();
            Console.WriteLine("Enter how many employers info`s you want to incode :");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how many employers you want to incode : ");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Imployers names and lon:");
            Console.WriteLine("====================================================");

            //arr1.printArray(i,j);
            Operations.printArray(i, j);

            //Console.ReadKey();
        }
    }
}
