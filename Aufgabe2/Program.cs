Console.WriteLine("Wie viel Tage hat der Monat, für den Sie die Sekunden berechnen wollen?: ");
long zahl1 = Convert.ToInt64(Console.ReadLine());

long sekunden = zahl1 * 24 * 60 * 60;

Console.WriteLine("Der Monat hat " + sekunden + " Sekunden.");