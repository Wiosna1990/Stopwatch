for(int i = 0; i <=59; i++)
{
    
    for(int j=0; j<=59; j++)
    {
        for (int k = 0; k < 100; k++)
        {
            Console.Clear();
            Console.WriteLine($"{i}m {j}s {k}");
            Thread.Sleep(10);

        }

    }
}
