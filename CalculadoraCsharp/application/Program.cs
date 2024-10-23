using System;
using CalculadoraCsharp.view;

namespace CalculadoraCsharp.application
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            // Exibe o menu chamando a função Show da classe Menu
            Console.WriteLine("REFLECTION:\n");
            Menu.Show();
            Console.WriteLine("\n Execução da Calculadora");
            Menu.showCalc();

            // Para manter o programa em execução após exibir o menu
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
