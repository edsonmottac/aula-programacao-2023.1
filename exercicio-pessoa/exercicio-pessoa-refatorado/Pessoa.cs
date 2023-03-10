using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_pessoa_refatorado
{
    internal class Pessoa 
    {

        

        private string? nome;
        private string? cpf;
        private string? rg;
        private Turma? turma;

  
        public string? Nome { get => nome; set => nome = value; }
        public string? Cpf { get => cpf; set => cpf = value; }
        public string? Rg { get => rg; set => rg = value; }
        public Turma? Turma { get => turma; set => turma = value; }


        public void ListarPessoas()
        {
            Console.WriteLine("Listar Pessoas");
        }

    }


    

}
