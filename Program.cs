using System;

namespace _20_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nomes = new string[2];
            float  [] notas = new float [8];
            float  [] media = new float [2];
            
            
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine($"Digite o {i+1}º nome");
                nomes[i] = Console.ReadLine();

                for (var x = 0; x < 4; x++)
                {
                    Console.WriteLine($"Digite a {x+1}º nota:");
                    notas[x] = float.Parse(Console.ReadLine());
                }
                
                media[i] = CalcularMedia(notas);

            }
            
            Console.ForegroundColor = ConsoleColor.Blue;

            foreach (string nomeAvulso in nomes)
            {
                Console.WriteLine(nomeAvulso);
            }

            Console.ForegroundColor = ConsoleColor.Red;

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Nome : {nomes[i]} - Média : {media[i]} ");
            }
        
            Console.ForegroundColor = ConsoleColor.Blue;
            
            
        
        
        }//fim do main

        static float CalcularMedia(float[] numeros){

            float soma = 0;

            for (var i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            float calculo = soma / numeros.Length;

            return calculo;

        }//fim do calc
    }
}
