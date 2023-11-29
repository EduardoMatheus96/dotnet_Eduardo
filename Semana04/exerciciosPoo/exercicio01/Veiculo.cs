public class Veiculo
{
    public Veiculo() { }
    string modelo;
    string ano;
    string cor;

    // Modificação para Exercicio 02
    public int IdadeVeiculo => DateTime.Now.Year - int.Parse(Ano);

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public string Ano{
        get { return ano; }
        set { ano = value; }
    }
    public string Cor{
        get { return cor; }
        set { cor = value; }
    }
}
