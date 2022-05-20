using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WorkBJA
{

    class Program
    {
        static void Main()
        {
            Pilha MinhaPilha = new Pilha();
            Fila MinhaFila = new Fila();

            do
            {
                Funcionário x = new Funcionário();

                Console.Write("\nNome do Funcionário: ");
                x.Nome = Console.ReadLine();

                Console.Write("Salário (R$).......: ");
                x.Salário = double.Parse(Console.ReadLine());

                MinhaFila.Inserir(x);

                Console.WriteLine("\nDeseja inserir outro funcionário? (ESC cancela...)");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            MinhaFila.Mostrar();

            MinhaFila.Transferir(MinhaPilha);

            MinhaPilha.Mostrar();
        }
    }
}
