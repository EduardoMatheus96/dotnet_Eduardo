
public class Medico : Pessoa
{
    string crm;

    public Medico() {}
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

    public void adicionarMedico(Medico medico, List<Medico> medicos){
        if (medicos.Any(m => m.Crm == medico.Crm ||m.Cpf == medico.Cpf))
        {
            throw new ArgumentException("Medico invalido, CRM ou CPF Ja presente na lista de medicos !!!");
        }
        else medicos.Add(medico);
    }
}
