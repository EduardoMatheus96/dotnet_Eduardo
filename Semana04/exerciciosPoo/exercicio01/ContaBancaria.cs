public class ContaBancaria
{
    double saldo;

    public double Saldo
    {
        get { return saldo; }
        set
        {
            if (value > -1)
            {
                saldo = value;
            }
            else throw new ArgumentException("O Saldo não pode ser negativo");
        }
    }
}
