public class VerificandoAcessoAAreaRestrita
{
    public static void verificarAcesso(int senha, int nivelAcesso)
    {
        if (senha == 42 && nivelAcesso >= 5)
        {
            Console.WriteLine("Acesso liberado");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }
    }
}