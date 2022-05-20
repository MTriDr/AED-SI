using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBJA
{
    class Fila
    {
        private Elemento Início;
        private Elemento Fim;
        private Elemento Aux;

        public Fila()
        {
            Início = null;
            Fim = null;
        }

        public void Inserir(Funcionário x)
        {
            Elemento Novo = new Elemento();

            Novo.Func = x;

            if (Início == null)
            {
                Início = Novo;
                Fim = Novo;
            }
            else
            {
                Fim.Próx = Novo;

                Fim = Novo;
            }
        }

        public void Mostrar()
        {
            Console.Clear();

            Console.WriteLine("Início");
            
            Aux = Início;

            while (Aux != null)
            {
                Console.WriteLine($"    {Aux.Func.Nome} - R$ {Aux.Func.Salário}");

                Aux = Aux.Próx;
            }

            Console.Write($"Fim");

            Console.ReadKey();
        }

        public void Retirar()
        {
            Início = Início.Próx;
        }

        public void Esvaziar()
        {
            Início = null;
        }

        public void Transferir(Pilha MP)
        {
            Aux = Início;

            while (Aux != null)
            {
                MP.Inserir(Aux.Func);

                Aux = Aux.Próx;
            }
        }
    }
}
