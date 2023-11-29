
public class Paciente : Pessoa
{
    string sexo;
    List<string> sintomas;

    public Paciente(string _nome, string _dataDeNascimento, string _cpf, string sexo, List<string> sintomas)
    {
        this.nome = _nome;
        this.dataDeNascimento = _dataDeNascimento;
        this.cpf = _cpf;
        this.sexo = sexo;
        this.sintomas = sintomas;
    }

    public string Sexo
    {
        get { return sexo; }
        set
        {
            if (value.ToLower() != "MASCULINO" || value.ToLower() != "feminino")
            {
                throw new ArgumentException("Insira um sexo valido !!!");
            }
            else
            {
                sexo = value.ToLower();
            }
        }
    }

    public List<string> Sintomas
    {
        get { return sintomas; }
        set { this.sintomas = value; }
    }

    public void adicionarPaciente(Paciente paciente, List<Paciente> pacientes){
        if (medicos.Any(p => p.Cpf == paciente.Cpf))
        {
            throw new ArgumentException("Paciente invalido, CRM ou CPF Ja presente na lista de medicos !!!");
        }
        else medicos.Add(medico);
    }
}
