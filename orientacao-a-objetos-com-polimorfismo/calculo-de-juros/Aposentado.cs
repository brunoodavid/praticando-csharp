public class Aposentado : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        return valor + (valor * 0.015m * meses);
    }
}