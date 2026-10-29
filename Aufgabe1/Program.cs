Console.WriteLine("Dieses Programm addiert die Summe von zwei Zahlen.");

Console.Write("Zahl 1: ");
string eingabe = Console.ReadLine();
int zahl1 = Convert.ToInt32(eingabe);

Console.Write("Zahl 2: ");
eingabe = Console.ReadLine();
int zahl2 = Convert.ToInt32(eingabe);

Console.WriteLine("Summe: " + (zahl1 + zahl2));