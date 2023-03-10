using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_pessoa_refatorado
{
    internal class Aluno : Pessoa, IEstudante
    {
        private string? matricula;
        private string? semestre;
        public string? Matricula { get => matricula; set => matricula = value; }
        public string? Semestre { get => semestre; set => semestre=value; }

        public void IncluirALuno()
        {
            Console.WriteLine("Usuáiro Inserido com Sucesso");
        }
    }



}
