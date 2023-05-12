using System;

namespace forca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = new string[] { "abacaxi", "cenoura", "melao" };
                        
            Random randNum = new Random();
            string sorteado = palavras[randNum.Next(0, 3)];
            int tentativa = 0;
            char letra;
            bool forValida = false;

            char[] palavraFatia = new char[sorteado.Length];
            
            for(int i = 0;  i < sorteado.Length; i++)
            {
                palavraFatia[i] = '_';
            }
            while (tentativa < 6)
            {
                Console.WriteLine("Vidas: " + tentativa);
                for(int i = 0;i < palavraFatia.Length; i++)
                {
                    Console.Write(palavraFatia[i]);
                }

                forValida = false;
                Console.WriteLine("\n Digite sua letra: ");
                letra = char.Parse(Console.ReadLine());

                for(int i = 0; i < sorteado.Length; i++)
                {
                    if (sorteado[i] == letra)
                    {
                        Console.WriteLine("Letra correta");
                        forValida = true;

                        palavraFatia[i] = letra; break;
                    }
                }
                if (forValida != true)
                {
                    Console.WriteLine("Menos uma vida: ");
                    tentativa++;
                }
            }
            Console.WriteLine(sorteado);
            Console.ReadKey();

        }
    }
}