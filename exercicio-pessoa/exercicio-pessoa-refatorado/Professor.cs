using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_pessoa_refatorado
{
    internal class Professor : Pessoa, IEducador
    {

        private DateTime admissao;
        private string? matricula;
        private float salario;
        
        public DateTime Admissao { get => admissao; set => admissao = value; }
        public string? Matricula { get => matricula; set => matricula=value; }
        public float Salario { get => salario; set => salario = value; }

        public void IncluirProfessor()
        {
            Console.WriteLine("Professor Incluído com Sucesso");
        }
    }
}
