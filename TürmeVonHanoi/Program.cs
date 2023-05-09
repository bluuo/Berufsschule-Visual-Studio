using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Willkommen zu den Türmen von Hanoi!");
        Console.Write("Bitte geben Sie die Anzahl der Scheiben ein: ");
        int scheibenAnzahl = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        BerechneTuermeVonHanoi(scheibenAnzahl, 'A', 'C', 'B');

        Console.ReadLine();
    }

    static void BerechneTuermeVonHanoi(int scheiben, char vonTurm, char zuTurm, char hilfsTurm)
    {
        if (scheiben == 1)
        {
            Console.WriteLine($"Bewege Scheibe 1 von Turm {vonTurm} zu Turm {zuTurm}");
            return;
        }

        BerechneTuermeVonHanoi(scheiben - 1, vonTurm, hilfsTurm, zuTurm);
        Console.WriteLine($"Bewege Scheibe {scheiben} von Turm {vonTurm} zu Turm {zuTurm}");
        BerechneTuermeVonHanoi(scheiben - 1, hilfsTurm, zuTurm, vonTurm);
    }
}
