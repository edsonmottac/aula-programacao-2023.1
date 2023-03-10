using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Carro : Veiculo
    {
        private int qt_rodas;

        public int Qt_rodas { get => qt_rodas; set => qt_rodas = value; }

        public void Dirigir()
        {
            Console.WriteLine("Dirigir meu Carro");
        }
    }
}
