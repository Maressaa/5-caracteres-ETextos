using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 05 - Caracteres e Textos");

        char letra = 'a';
        //Console.WriteLine(letra);

        //letra = (char)65;
        //Console.WriteLine(letra);

        letra = (char)77;
        Console.Write(letra);

        letra = (char)97;
        Console.Write(letra);

        letra = (char)114;
        Console.Write(letra);

        letra = (char)101;
        Console.Write(letra);

        letra = (char)115;
        Console.Write(letra);

        letra = (char)115;
        Console.Write(letra);

        letra = (char)97;
        Console.WriteLine(letra);


        letra = (char)77;
        Console.WriteLine(letra);

        letra = (char)97;
        Console.WriteLine(letra);

        letra = (char)114;
        Console.WriteLine(letra);

        letra = (char)101;
        Console.WriteLine(letra);

        letra = (char)115;
        Console.WriteLine(letra);

        letra = (char)115;
        Console.WriteLine(letra);

        letra = (char)97;
        Console.WriteLine(letra);

        string primeiraFrase = "SENAI - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = @"Cursos disponíveis: 
-C 
-C++ 
-HTML 
-CSharp";
        Console.WriteLine(cursos);

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}