using System.Runtime.ConstrainedExecution;

namespace Aufgabe_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int zeile = 1; zeile <= 10; zeile++)
            {
                for (int spalte = 1; spalte <= 10; spalte++)
                {
                    Console.Write(zeile * spalte);
                    Console.Write('\t');
                }

                Console.WriteLine();
            }
        }
    }
}