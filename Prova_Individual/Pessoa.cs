public class Pessoa
{
    protected string nome;
    protected string dataDeNascimento;
    protected string cpf;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string DataDeNascimento
    {
        get { return dataDeNascimento; }
        set
        {
            if (DateTime.TryParse(value, out DateTime data) && data.Year > 0 && data.Year < DateTime.Now.Year)
            {
                dataDeNascimento = value;
            }
            else
            {
                throw new ArgumentException("Data inválida");
            }
        }
    }

    public string Cpf
    {
        get { return cpf; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Insira um cpf valido (11 digitos)");
            }
            else if (value.Length != 11)
            {
                throw new ArgumentException("Insira um cpf valido (11 digitos)");
            }
            else
                cpf = value;
        }
    }
}