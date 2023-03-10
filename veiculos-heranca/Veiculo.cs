using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Veiculo
    {
        private string? placa;
        private string? modelo;
        private string? marca;

        private int qt_rodas;
        public int Qt_rodas { get => qt_rodas; set => qt_rodas = value; }

        public string? Placa { get => placa; set => placa = value; }
        public string? Modelo { get => modelo; set => modelo = value; }
        public string? Marca { get => marca; set => marca = value; }

        public void Ligar()
        {
            Console.WriteLine("Ligar");
        }
        public void Desligar()
        {
            Console.WriteLine("Desligar");
        }

        public virtual void Dirigir()
        {

        }
    }
}
