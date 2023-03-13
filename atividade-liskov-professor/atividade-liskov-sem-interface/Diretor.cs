using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_liskov_sem_interface
{
    internal class Diretor : Funcionario
    {
        public override void calculaSalarioMensal(float ch)
        {
            this.Salario = ((decimal)(ch * 300));
        }

        public void RealizarAvaliacaoDesempenho()
        {
            Console.WriteLine("Gera relatório de performance -  Diretor");
        }
    }
}
