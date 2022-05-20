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
            // Lista Duplamente Encadeada

            Lista MinhaLista = new Lista();

            MinhaLista.InserirInício(4);

            MinhaLista.InserirInício(19);

            MinhaLista.InserirInício(11);

            MinhaLista.InserirFinal(8);

            MinhaLista.InserirFinal(10);

            MinhaLista.InserirFinal(16);

            MinhaLista.MostrarListaINIFIM();

            Console.ReadKey();

            Console.WriteLine("\n\n");

            MinhaLista.MostrarListaFIMINI();

            Console.ReadKey();

            MinhaLista.Retirar(8);

            Console.WriteLine("\n\n");

            MinhaLista.MostrarListaFIMINI();

            Console.ReadKey();
        }
    }
}