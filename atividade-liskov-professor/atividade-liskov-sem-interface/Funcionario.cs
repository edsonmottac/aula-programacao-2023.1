using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_liskov_sem_interface
{
    internal abstract class Funcionario
    {
        private string? primeiro_nome;
        private string? segundo_nome;
        private decimal salario;

        private Coordenador? coordenador;

        public string? Primeiro_nome { get => primeiro_nome; set => primeiro_nome = value; }
        public string? Segundo_nome { get => segundo_nome; set => segundo_nome = value; }
        public decimal Salario { get => salario; set => salario = value; }

        public Coordenador? Gerente { get => coordenador; set => coordenador = value; }

        public abstract void calculaSalarioMensal(float ch);

    }
}
