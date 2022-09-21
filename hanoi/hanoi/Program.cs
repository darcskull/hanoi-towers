using System;

namespace hanoi
{
    class Program
    {
        
        
          
          public static void solveTowers(int n, string start, string end, string temp)
            {
           
            if (n > 0)
                {
                    solveTowers(n - 1, start, temp, end);
                
                    Console.WriteLine("Move disk №" + n + ' '+"from "+ start + ' '+"to " + end);
                    solveTowers(n - 1, temp, end, start);

                }
           
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете броят на дисковете");
            int disknum = int.Parse(Console.ReadLine());
            string start = "Tower 1";
            string temp = "Tower 2";
            string end = "Tower 3";

            var t1 = DateTime.Now;

           solveTowers(disknum, start, end, temp);
            var t2 = DateTime.Now;
            Console.WriteLine("Time is " + (t2 - t1).Milliseconds);
           
           
        }
    }
}
