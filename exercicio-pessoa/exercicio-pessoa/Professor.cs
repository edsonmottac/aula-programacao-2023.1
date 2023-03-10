using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_pessoa
{
    internal class Professor : Pessoa
    {
        private string? matricula;
        private DateTime admissao;
        private float salario;

        public string? Matricula { get => matricula; set => matricula = value; }
        public DateTime Admissao { get => admissao; set => admissao = value; }
        public float Salario { get => salario; set => salario = value; }


        public void IncluirProfessor()
        {
            Console.WriteLine("Incluir Professor");
        }


    }
}
