using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao1
{
    internal class Carro : Veiculo
    {
        public override void Desligar()
        {
            Console.WriteLine("Desligar meu Carro");
        }

        public override void Dirigir()
        {
            Console.WriteLine("Dirigir meu Carro");
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligar meu Carro");
        }

       

    }
}
