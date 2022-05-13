using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000;


       for(int mes = 1; mes <= 12; mes++)
        {
            //investimento = investimento + investimento * 0.005;
            investimento *= 1.005;
            Console.WriteLine("No mês "+ mes + " R$ " + investimento);
          
            //mes+=2 incremento com valor maior de 1 
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();

    }
}