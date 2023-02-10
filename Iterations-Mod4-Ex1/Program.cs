namespace Iterations_Mod4_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 15; j++)
            {
                Console.WriteLine($"Iteration #{j+1}");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}