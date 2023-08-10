for(int i = 0; i <=59; i++)
{
    
    for(int j=0; j<=59; j++)
    {
        
        for (int k = 0; k < 100; k++)
        {
            Console.Clear();
            if (j < 10)
            {
                Console.WriteLine($"0{i}:0{j}:{k}");

            }
            else if (j>9 && i<10)
            {
                Console.WriteLine($"0{i}:{j}:{k}");
            }
            else
            {
                Console.WriteLine($"{i}:{j}:{k}");
            }

            
            Thread.Sleep(1);

        }
        

    }
}
