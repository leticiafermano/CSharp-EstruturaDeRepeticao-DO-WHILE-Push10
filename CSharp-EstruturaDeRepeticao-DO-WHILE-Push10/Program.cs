using System;

namespace LogicaDeProgramacao_P6_DO_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Estrutura de repetição:
            DO WHILE (repita ate)
             */

            int cont = 10; //Executa
            do
            {
                Console.WriteLine("Letícia & Célio");
                cont++;
            }

            while (cont < 5); //Verifica
            Console.WriteLine(cont);
        }
    }
}
