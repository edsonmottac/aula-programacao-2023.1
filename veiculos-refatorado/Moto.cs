using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao1
{
    internal class Moto : Veiculo
    {
        public override void Desligar()
        {
            Console.WriteLine("Desligar Moto!");
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligar Moto!");
        }

        public override void Dirigir()
        {
            Console.WriteLine("Dirigir minha moto");
        }

    }


}
