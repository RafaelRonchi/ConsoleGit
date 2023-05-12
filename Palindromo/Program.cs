namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra = " ";
            Console.WriteLine("Digite a palavra: ");
            palavra = Console.ReadLine();

           

            char[] caracteres = palavra.ToCharArray();
            Array.Reverse(caracteres);


            int resultado = palavra.Length;
            int total = 0;

            for (int i = 0; i < caracteres.Length; i++)
            {
                if (palavra[i] == caracteres[i])
                {
                    total++;
                }
            }

            if(total == resultado)
            {
                Console.WriteLine("A string " + palavra + " é um palindromo");
            }
            else
            {
                Console.WriteLine("A string " + palavra + " não é um palíndromo");

            }

        }
    }
}