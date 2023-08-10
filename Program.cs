using System;
using System.Reflection.PortableExecutable;
using System.Threading;

class Program
{
    static public void Main(String[] args)
    {

        int h = 0, min = 0, sec = 0;

        Console.WriteLine("Press x to start");
        var input = Console.ReadLine();

        while (input =="x")
        {
            
                sec++;
                if (sec == 60)
                {
                    sec = 0;
                    min++;
                    if (min == 60)
                    {
                        min = 0;
                        h++;
                    }

                }
            
            Console.WriteLine($"{h}:{min}:{sec}");
            Thread.Sleep(1000);


            Console.Clear();
            
        }


    }


}