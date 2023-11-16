// dotNet - Aula 03 - Estruturas de Fluxo


#region  foreach

string[] colecao = {"Item1","Item2","Item3","Item4"};

foreach (string item in colecao)
{
    Console.WriteLine(item); 
}

#endregion

#region Resolução exercício - divisiveis

Console.WriteLine("\nResolução exercício 1\n"); 

for(int i = 0; i <= 30; i++){
    if(i % 3 == 0){
        Console.WriteLine( i + " é divisivel por 3"); 
    }else if(i % 4 == 0){
        Console.WriteLine( i + " é divisivel por 4"); 
    }
}
#endregion 

#region Resolução exercício - Fibonacci
Console.WriteLine("\n Sequencia  Fibonacci\n"); 

int numeroAnterior = 0;
int numeroAtual = 1;
int novoNumero;
int fibonacci;


for (int i = 0; i < 60; i++)
{
    fibonacci = numeroAnterior + numeroAtual;
    Console.WriteLine(fibonacci);

    numeroAnterior = numeroAtual;
    numeroAtual = fibonacci;
}

#endregion 

#region string- entrada de dados

    string? str = Console.ReadLine();
    Console.WriteLine($"Text");
    Console.WriteLine("A string foi " + str);
    
 

#endregion 

#region 
    how to display the fribonacci sequence

    List<int> numbers = new List<int>();
    numbers.Add(1);
    numbers.Add(2);
    numbers.Add(3);


    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
#endregion


/* 
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of Fibonacci numbers to display:");
        int numberOfFibonacciNumbers = Convert.ToInt32(Console.ReadLine());

        int[] fibonacciSequence = GenerateFibonacciSequence(numberOfFibonacciNumbers);

        Console.WriteLine("The Fibonacci sequence is:");
        foreach (int number in fibonacciSequence)
        {
            Console.WriteLine(number);
        }
    }

    static int[] GenerateFibonacciSequence(int numberOfFibonacciNumbers)
    {
        int[] fibonacciSequence = new int[numberOfFibonacciNumbers];
        fibonacciSequence[0] = 0;
        fibonacciSequence[1] = 1;

        for (int i = 2; i < numberOfFibonacciNumbers; i++)
        {
            fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
        }

        return fibonacciSequence;
    }
} */