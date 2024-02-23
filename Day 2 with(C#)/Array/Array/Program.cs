internal class Program
{
    
    private static void Main(string[] args)
    {
       int [] array =new int[10];
        array[0] = 11;
        array[1] = 22;
        array[2] = 543;
        array[3] = 44;
        array[4] = 5;
        array[5] = 46;
        array[6] = 57;
        array[7] = 38;
        array[8] = 39;
        array[9] = 610;
         for (int i = 0; i <= array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

    }
}