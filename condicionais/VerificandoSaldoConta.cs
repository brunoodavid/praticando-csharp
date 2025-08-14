public class VerificandoSaldoConta
{
    public static void verificarSaldoEmConta()
    {
        decimal saldo = -26.75m;

        if (saldo < 0)
        {
            Console.WriteLine("O saldo está negativo");
        }
        else if (saldo == 0)
        {
            Console.WriteLine("O saldo é de zero.");
        }
        else
        {
            Console.WriteLine("O saldo é positivo");
        }
    }
}