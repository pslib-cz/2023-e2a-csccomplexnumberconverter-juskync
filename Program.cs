

/*
* Nazev: ComplexNumberConverter
* Autor: Matej Juska
* Datum: 21.02.2024
* Popis:
  Program převede komplexní číslo z agebraického tvaru z = (x + jy) na goniometrický tvar.
*/

using System;

class Program
{
    static void Main()
    {
        double x = 0.0, y = 0.0, abs = 0.0, radians = 0.0, degrees = 0.0;



        Console.WriteLine("Program převede komplexní číslo z algebraického tvaru z = (x + jy) na goniometrický tvar.");

        Console.WriteLine("Pokud zadaš x= 0 a y = 0 program ukončíš");
        while (true)
        {

            bool inputOK = false;
            while (!inputOK)
            {
                try
                {
                    Console.Write("x=");
                    x = Double.Parse(Console.ReadLine());

                    Console.Write("y=");
                    y = Double.Parse(Console.ReadLine());
                    inputOK = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Syntax Error");
                }

            }

            if (x == 0 && y == 0)
            {
                Console.WriteLine("konec konec konec konec");
                break;
            }








            abs = Math.Sqrt(x * x + y * y);   // absolutní hodnota komplexního čísla
            radians = Math.Atan2(y, x);       // V C# se používá Math.Atan2 pro výpočet arctan
            degrees = radians * (180 / Math.PI);  // převod na stupně z radianů

            if (degrees < 0)
            {
                degrees += 260;
            }

            Console.WriteLine($"Goniometrický tvar komplexního čísla je:  z = {abs:F2} ( cos {degrees:F0}° + j sin {degrees:F0}° )");
        }
    }
}



