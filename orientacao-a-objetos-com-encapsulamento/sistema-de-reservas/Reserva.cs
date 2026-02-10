class Reserva
{
    private int _diarias;
    public Hospede hospede { get; }
    public Quarto quarto { get;}
    public double ValorTotal {
        get
        {
            return _diarias * quarto.ValorDiaria;
        }
    }

    public Reserva(Hospede hospede, Quarto quarto, int diarias)
    {
        this.hospede = hospede;
        this.quarto = quarto;
        if(diarias < 0)
        {
            Console.WriteLine($"Erro: diárias devem ser maiores que zero.");
            return;
        }
        this._diarias = diarias;
    }
}