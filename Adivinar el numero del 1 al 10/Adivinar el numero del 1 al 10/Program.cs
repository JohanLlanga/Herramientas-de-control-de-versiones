using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("¡Bienvenido al juego de adivinanzas!");

        Random random = new Random();
        int numeroSecreto = random.Next(1, 11);
        int intentos = 0;
        bool adivinado = false;

        Console.WriteLine("He pensado en un número del 1 al 10. ¡Adivina!");

        while (!adivinado)
        {
            Console.Write("Introduce tu suposición (o escribe 'Rendirse' para revelar el número): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "rendirse")
            {
                adivinado = true;
                Console.WriteLine($"Te has rendido. El número secreto era: {numeroSecreto}");
            }
            else if (int.TryParse(input, out int suposicion))
            {
                intentos++;

                if (suposicion == numeroSecreto)
                {
                    adivinado = true;
                    Console.WriteLine($"¡Correcto! ¡Has adivinado en {intentos} intentos!");
                }
                else
                {
                    Console.WriteLine("Incorrecto. ¡Inténtalo de nuevo!");
                    if (suposicion < numeroSecreto)
                        Console.WriteLine("El número secreto es mayor.");
                    else
                        Console.WriteLine("El número secreto es menor.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido del 1 al 10 o 'Rendirse'.");
            }
        }

        Console.WriteLine("Gracias por jugar. ¡Hasta luego!");
    }
}
