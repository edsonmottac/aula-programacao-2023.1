using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_liskov_sem_interface
{
    internal class Professor : Funcionario
    {
        public void AtribuirSuperior(Coordenador g)
        {
            this.Gerente = g;
        }

        public override void calculaSalarioMensal(float ch)
        {
            this.Salario = ((decimal)(ch * 100));
        }
    }
}
