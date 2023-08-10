class Program
{
    public static void Main()
    {
        DateTime time = new DateTime(2023, 08, 10, 00, 00, 00);
        Console.WriteLine("Press x to Start");


        var input = Console.ReadLine();
        Console.WriteLine(time);
        time.AddSeconds(1);
        Thread.Sleep(1000);
        while(input == "x")

        {
            Console.Clear();
            time = time.AddSeconds(1);
            Console.WriteLine(time);
            Thread.Sleep(1000);
            
        }
        

    }
  
}