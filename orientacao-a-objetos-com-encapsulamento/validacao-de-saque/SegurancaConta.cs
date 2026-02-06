internal class SegurancaConta
{
    public static bool ValidarSaque(double valor)
    {
        if (valor > 1000)
        {
            Console.WriteLine($"Saque negado pela política de segurança.");
            return false;
        }
        return true;
    }
}