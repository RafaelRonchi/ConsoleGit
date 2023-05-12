namespace ConsoleGit
{
    internal class Ordem
    {
        static void Main(string[] args)
        {
            int[] listaUsuario = new int[10];
            int[] listaCopia = new int[10];

            Console.WriteLine("Digite 10 números inteiros: ");
            for (int i = 0; i < listaUsuario.Length; i++)
            {
                listaUsuario[i] = int.Parse(Console.ReadLine());
                listaCopia[i] = listaUsuario[i];
            }

            for (int i = 0; i < listaUsuario.Length; i++)
            {
                for (int j = 0; j < listaUsuario.Length - 1; j++) 
                {
                    if (listaUsuario[i] < listaUsuario[j])
                    {
                        int parametroNum = listaUsuario[i];
                        listaUsuario[i] = listaUsuario[j];
                        listaUsuario[j] = parametroNum;
                    }
                }
            }
            Console.WriteLine("\nLista informada: ");
            for (int i = 0; i < listaCopia.Length; i++)
            {
                Console.Write(listaCopia[i] + " ");

            }

                Console.WriteLine("\nArrumado em ordem crescente: ");
            for (int i = 0; i < listaUsuario.Length ; i++) {
                Console.Write(listaUsuario[i] + " ");   
            }

        }
    }
}