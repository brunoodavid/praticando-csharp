class Quarto
{
    public int Numero { get; set; }
    private double _valorDiaria;
    public double ValorDiaria {
        get
        {
            return _valorDiaria;
        }
        set
        {
            if(value < 0)
            {
                Console.WriteLine($"Erro: O valor deve ser positivo");
                return;
            }
            _valorDiaria = value;
        } 
    } 

    public Quarto(int numero)
    {
        this.Numero = numero;
    }
}