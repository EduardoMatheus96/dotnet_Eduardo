
public class Medico : Pessoa
{
    string crm;

    public string Crm
    {
        get { return crm; }
        set
        {
            if (value == null || value == "")
            {
                throw new ArgumentException("Insira um crm correto ");
            }
            else
            {
                crm = value;
            }
        }
    }
}
