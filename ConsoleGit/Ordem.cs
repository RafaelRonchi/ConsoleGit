namespace ConsoleGit
{
    internal class Ordem
    {
        static void Main(string[] args)
        {
            int[] listaInformada = new int[10];
            Console.WriteLine("Digite 10 numeros: ");
            for(int i = 0; i < listaInformada.Length; i++)
            {
                listaInformada[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}