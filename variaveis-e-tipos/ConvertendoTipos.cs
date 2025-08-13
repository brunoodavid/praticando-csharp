public class ConvertendoTipos
{
    public void conventerTipos()
    {
        decimal pesoContainer = 18.75m;
        int veiculosNecessarios = (int)pesoContainer;

        Console.WriteLine($"Veículos necessários: {veiculosNecessarios}");
    }
}