namespace exercicio_pessoa_refatorado
{
    internal interface IEstudante
    {
        string? Matricula { get; set; }
        string? Semestre { get; set; }

        void IncluirALuno();
    }
}