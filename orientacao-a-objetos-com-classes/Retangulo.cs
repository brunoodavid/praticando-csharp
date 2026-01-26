class Retangulo
{
    public double Largura;
    public double Altura;

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public double CalcularArea()
    {
        double area = Largura * Altura;
        return area;
    }


}