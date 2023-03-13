using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_liskov
{
    internal class Coordenador : Funcionario, IGestor, ISuperior
    {
        public void AtribuirSuperior(Coordenador g)
        {
            this.Gerente = g;
        }

        public override void calculaSalarioMensal(float ch)
        {
            this.Salario = ((decimal)(ch * 200));
        }

        public void RealizarAvaliacaoDesempenho()
        {
            Console.WriteLine("Gera relatório de performance -  Coordenador");
        }
    }
}
