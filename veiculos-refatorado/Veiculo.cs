using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao1
{
    internal abstract class Veiculo
    {
        private string? placa;
        private string? marca;
        private string? modelo;
        private int rodas;

        public string? Placa { get => placa; set => placa = value; }
        public string? Marca { get => marca; set => marca = value; }
        public string? Modelo { get => modelo; set => modelo = value; }
        public int Rodas { get => rodas; set => rodas = value; }

        public abstract void Ligar();

        public abstract void Desligar();

        public abstract void Dirigir();
        
        public virtual void teste()
        {
            Console.WriteLine("teste");
        }

    }


}
