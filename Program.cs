using System;

namespace _20_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nomes = new string[10];
            int [] notas = new int[40];
            
            for (var contador = 0; contador < 10; contador++)
            {
                Console.WriteLine($"Digite o {contador+1}º nome");
                nomes[contador] = Console.ReadLine();

                Console.WriteLine($"Digite a primeira nota do {contador+1}º aluno");
                notas[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a segunda nota do {contador+1}º aluno");
                notas[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a terceira nota do {contador+1}º aluno");
                notas[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a quarta nota do {contador+1}º aluno");
                notas[contador] = int.Parse(Console.ReadLine());
             
            }

            foreach (var item in nomes)
            {
                Console.WriteLine($"O aluno {nomes}");
            }

            
            

        }//fim do main

        int media(int a, int b, int c, int d)
        {
            int media = (a+b+c+d)/4;
            Console.WriteLine("A média é:");
            return media;
        }//média




    }
}
