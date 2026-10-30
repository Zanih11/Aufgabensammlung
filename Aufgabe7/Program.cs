namespace Aufgabe_7
{
    internal class program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
               
                    Console.Write(i);

                if (i != 30)
                    Console.Write(", "); 
            }
        }
    }
}