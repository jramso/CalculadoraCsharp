using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using CalculadoraCsharp.model.operation;
using CalculadoraCsharp.dto;
using CalculadoraCsharp.Controller;

namespace CalculadoraCsharp.view;
public class Menu {

    public RequestDto ShowDTO()
    {
        this.showMenu();  
        return this.CaptureValues();
    }


    public void showMenu()
    {
        Console.WriteLine("Olá bem vindo ao não sei calcular de cabeça");
        Console.WriteLine("Digite a operação Desejada:");
        Console.WriteLine("1 Soma:");
        Console.WriteLine("2 Subtração");
        Console.WriteLine("3 Multiplicação:");
        Console.WriteLine("4 divisão:");
        Console.WriteLine("5 - Sair do programa");
    }

    private RequestDto CaptureValues()
    {
        Console.WriteLine("Escolha a operação (digite 5 para sair):");
        int opcao = int.Parse(Console.ReadLine());

        if (opcao == 5)
        {
            Environment.Exit(0);
        }

        Console.WriteLine("Informe o primeiro valor:");
        int valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor:");
        int valor2 = int.Parse(Console.ReadLine());

        return new RequestDto(opcao, valor1, valor2);
    }

    public void ShowResult(ResponseDto responseDTO)
    {
        Console.WriteLine("O Resultado é: " + responseDTO.result);
        Console.WriteLine();  // Adiciona uma nova linha
        showCalc();
    }

    public static void showCalc()
    {
        Menu menu = new Menu();
        RequestDto requestDto = menu.ShowDTO();
        ControllerCalc controll = new ControllerCalc();
        ResponseDto response = controll.Calc(requestDto);
        menu.ShowResult(response);
    }


    public static void Show()
        {
            // Pega todas as classes do assembly atual que implementam a interface IOperation
            var operationType = typeof(Ioperation);
            IEnumerable<Type> types = Assembly.GetExecutingAssembly()
                                               .GetTypes()
                                               .Where(t => operationType.IsAssignableFrom(t) && t.IsClass);

            // Imprime o nome das classes que implementam a interface IOperation
            foreach (var type in types)
            {
                Console.WriteLine($"Classe que implementa IOperation: {type.Name}");
            }
        }
}




