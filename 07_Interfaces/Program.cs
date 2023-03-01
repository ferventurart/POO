using _07_Interfaces.Helper;
using System;

Menu menu = new(); // Declaro una nueva instancia de menu
menu.Imprimir(); // Imprimo el menu en pantalla con las diferentes opciones

string opcionIngresada;

do
{
    opcionIngresada = Console.ReadLine();

    if (!menu.ValidarOpcion(opcionIngresada))
    {
        Console.WriteLine("La opción ingresada es invalida");
        Console.WriteLine("Presione una tecla para continuar");
        Console.ReadKey();
        Console.Clear();
        menu.Imprimir();
    }

} while (!menu.Salir);

Console.WriteLine("Gracias por utilizar este programa.");
Console.WriteLine("Presione una tecla para salir...");
Console.ReadKey();