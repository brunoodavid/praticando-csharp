class Veiculo
{
    public string Placa { get; }
    private double _velocidadeAtual;
    public double VelocidadeAtual
    {
        get { return _velocidadeAtual; }
    }

    public Veiculo(string placa)
    {
        this.Placa = placa;
    }

    public void AtualizarVelocidade(double novaVelocidade)
    {
        this._velocidadeAtual = novaVelocidade;
    }
}