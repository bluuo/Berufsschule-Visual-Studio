﻿using System;

class Program
{
static void Main(string[] args)
    {
        Reservierungssystem rs = new Reservierungssystem();
        //Console.WriteLine(rs.freieSitze(3));
        Console.ReadKey();
    }
}

class Reservierungssystem
{
    private bool[,] kino = new bool[7, 30];                         // 2-dim. Array vom Typ boolean

    public Reservierungssystem()
    {
        Random random = new Random();                               // Kino zufällig besetzen
        for (int reihe = 0; reihe < 7; reihe++)
            for (int sitz = 0; sitz < 30; sitz++)
                kino[reihe, sitz] = random.Next(100) < 20;          // 80 % besetzt

        for (int reihe = 0; reihe < 7; reihe++)                     // Besetzung ausgeben
        {
            for (int sitz = 0; sitz < 30; sitz++)
            {
                if (kino[reihe, sitz])
                    Console.ForegroundColor = ConsoleColor.Green;   // frei -> grün
                else
                    Console.ForegroundColor = ConsoleColor.Red;     // besetzt -> rot
                Console.Write((reihe + 1) * 100 + sitz + 1);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.Write("Wie viele Sitz möchten Sie buchen?");
        Console.WriteLine();

        string anzahlSitzeString = Console.ReadLine();
        int anzahlSitze = Convert.ToInt32(anzahlSitzeString);

        int anfangSitze = freieSitze(anzahlSitze);

        if (anfangSitze == 0)
            Console.Write("Leider konnten wir keine Plätze für Sie finden.");
        else
            Console.Write("Ihre Sitzplätze sind " + anfangSitze + "-" + anfangSitze+anzahlSitze + " .");

        Console.WriteLine();

    }

    public int freieSitze(int anzahlSitze)
    {
        int freiNebereinander = 0;
        for (int reihe = 0; reihe < 7; reihe++)
        {
            for (int sitz = 0; sitz < 30; sitz++)
            {
                //Check if the seat is available
                if (kino[reihe, sitz])
                {
                    //Increase the number of free seats next to each other
                    freiNebereinander++;
                    //Check if the number of free seats next to each other is equal to the number of seats requested
                    if (freiNebereinander == anzahlSitze)
                    {
                        //Return the seat number of the first seat in the row
                        return ((reihe + 1) * 100 + sitz - anzahlSitze + 2);
                    }
                    //If the seat is not available
                }
                else
                {
                    //Reset the number of free seats next to each other
                    freiNebereinander = 0;
                }
            }
        }
        return 0;
    }
}

