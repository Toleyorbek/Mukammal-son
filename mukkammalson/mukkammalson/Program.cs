namespace mukkammalson
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {

                for (int j = 1; j <= b / 2; j++)
                {
                    if (i % j == 0)
                    {
                        Console.WriteLine(i / j);

                    }
                }


            }
        }
    }
}