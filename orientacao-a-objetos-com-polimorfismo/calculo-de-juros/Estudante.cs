public class Estudante : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        return valor + (valor * 0.01m * meses);
    }
}