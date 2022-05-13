using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 09 - Escopo");

        double n1, n2, n3, n4, media;

        Console.Write("Digite a nota 1: ");
        n1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = double.Parse(Console.ReadLine());

        media=(n1+n2+n3+n4)/4;
        Console.WriteLine(media);

        if (media >= 6)
        {
            Console.WriteLine("Aprovado!");
        }
        else if(media <= 4)
        {
            Console.WriteLine("Reprovado:(");
        }
        else
        {
            Console.WriteLine("Recuperação");
        }
     
        

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();

    }
}
