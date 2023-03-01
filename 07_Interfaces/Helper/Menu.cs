using System;
using _07_Interfaces.Models;

namespace _07_Interfaces.Helper;

public class Menu
{
    private string[] opciones = { "1.) Deposito", "2.) Consultar Saldo", "3.) Opción 3", "4.) Salir" };
    public bool Salir { get; set; }
    public BankAccount BankAccount  = new();
    public void Imprimir()
    {
        Console.WriteLine("Seleccione una opción:");
        foreach (string opcion in opciones)
        {
            Console.WriteLine(opcion);
        }
    }

    public bool ValidarOpcion(string opcionIngresada)
    {
        if (opcionIngresada == "1")
        {
            Console.WriteLine("Ingrese el monto del deposito");
            double monto = Convert.ToDouble(Console.ReadLine());
            string mensajeDeposito = BankAccount.Deposit(monto);

            Console.WriteLine(mensajeDeposito);
            Console.ReadKey();
            Console.Clear();
            Imprimir();
        }
        else if (opcionIngresada == "2")
        {
            Console.WriteLine(BankAccount.GetAtmMessage());
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
            Imprimir();
        }
        else if (opcionIngresada == "3")
        {
            Console.WriteLine("Ha seleccionado la opcion 3.");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Imprimir();
        }
        else if (opcionIngresada == "4")
        {
            Console.WriteLine("Ha seleccionado la opcion 4.");
            Salir = true;
        }
        else
        {
            return false;
        }

        return true;
    }
}