public class ControleDeVidas
{
    public void jogar()
    {
        int vida = 5;
        int novaVida = 0;

        vida--;
        vida++;
        vida++;

        novaVida = vida;

        Console.WriteLine($"Vidas finais: {novaVida}");

    }
}