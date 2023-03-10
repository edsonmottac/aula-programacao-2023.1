namespace exercicio_pessoa_refatorado
{
    internal interface IEducador
    {
        DateTime Admissao { get; set; }
        string? Matricula { get; set; }
        float Salario { get; set; }

        void IncluirProfessor();
    }
}