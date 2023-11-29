public class Relatorio
{
    List<Paciente> pacientes;
    List<Medico> medicos;

    public Relatorio(List<Paciente> pacientes, List<Medico> medicos)
    {
        this.pacientes = pacientes;
        this.medicos = medicos;
    }

    public void mostrarMedicosPorIdade(int idadeMinima, int idadeMaxima)
    {
        // Obtém o ano atual
        int anoAtual = DateTime.Now.Year;

        // Filtra os médicos com base na idade
        var medicosFiltrados = this.medicos.Where(medico =>
        {
            int anoNascimento = int.Parse(medico.DataDeNascimento.Split('/')[2]);
            int idade = anoAtual - anoNascimento;
            return idade >= idadeMinima && idade <= idadeMaxima;
        }).ToList();

        // Exibe os médicos filtrados
        Console.WriteLine($"Médicos com idade entre {idadeMinima} e {idadeMaxima} anos:");
        foreach (var medico in medicosFiltrados)
        {
            Console.WriteLine($"Nome: {medico.Nome}, Idade: {anoAtual - int.Parse(medico.DataDeNascimento.Split('/')[2])} anos, CPF: {medico.Cpf}, CRM: {medico.Crm}");
        }
    }

    public void MostrarPacientesPorIdade(int idadeMinima, int idadeMaxima)
    {
        // Obtém o ano atual
        int anoAtual = DateTime.Now.Year;

        // Filtra os pacientes com base na idade
        var pacientesFiltrados = this.pacientes.Where(paciente =>
        {
            int anoNascimento = int.Parse(paciente.DataDeNascimento.Split('/')[2]);
            int idade = anoAtual - anoNascimento;
            return idade >= idadeMinima && idade <= idadeMaxima;
        }).ToList();

        // Exibe os pacientes filtrados
        Console.WriteLine($"\nPacientes com idade entre {idadeMinima} e {idadeMaxima} anos:");
        foreach (var paciente in pacientesFiltrados)
        {
            Console.WriteLine($"Nome: {paciente.Nome}, Idade: {anoAtual - int.Parse(paciente.DataDeNascimento.Split('/')[2])} anos, CPF: {paciente.Cpf}, Gênero: {paciente.Sexo}");
        }
    }

    public void MostrarPacientesPorGenero(string sexoAlvo)
    {
        // Filtra os pacientes com base no gênero
        var pacientesFiltrados = pacientes.Where(paciente =>
            paciente.Sexo.Equals(sexoAlvo, StringComparison.OrdinalIgnoreCase))
            .ToList();

        // Exibe os pacientes filtrados
        Console.WriteLine($"\nPacientes do sexo {sexoAlvo}:");
        foreach (var paciente in pacientesFiltrados)
        {
            Console.WriteLine($"Nome: {paciente.Nome}, Idade: {CalcularIdade(paciente.DataDeNascimento)} anos, CPF: {paciente.Cpf}, Gênero: {paciente.Sexo}");
        }
    }

    public void MostrarPacientesEmOrdemAlfabetica()
    {
        // Ordena os pacientes por nome
        var pacientesOrdenados = pacientes.OrderBy(paciente => paciente.Nome).ToList();

        // Exibe os pacientes ordenados
        Console.WriteLine("\nPacientes em ordem alfabética:");
        foreach (var paciente in pacientesOrdenados)
        {
            Console.WriteLine($"Nome: {paciente.Nome}, Idade: {CalcularIdade(paciente.DataDeNascimento)} anos, CPF: {paciente.Cpf}, Gênero: {paciente.Sexo}");
        }
    }


    public void MostrarPacientesPorSintoma(string textoSintoma)
    {
        // Filtra os pacientes cujos sintomas contêm o texto informado
        var pacientesFiltrados = pacientes
            .Where(paciente => ContemSintoma(paciente.Sintomas, textoSintoma))
            .ToList();

        // Exibe os pacientes filtrados
        Console.WriteLine($"\nPacientes com sintomas contendo '{textoSintoma}':");
        foreach (var paciente in pacientesFiltrados)
        {
            Console.WriteLine($"Nome: {paciente.Nome}, Idade: {CalcularIdade(paciente.DataDeNascimento)} anos, CPF: {paciente.Cpf}, Gênero: {paciente.Sexo}, Sintomas: {string.Join(", ", paciente.Sintomas)}");
        }
    }

    // Tratar o dado dynamic
    private bool ContemSintoma(dynamic sintomas, string textoSintoma)
    {
        // Convertemos para uma lista de strings (assumindo que seja uma lista de strings)
        var listaSintomas = ((IEnumerable<object>)sintomas).Cast<string>().ToList();

        // Verificamos se a lista de sintomas contém o texto informado
        return listaSintomas.Any(sintoma => sintoma.Contains(textoSintoma, StringComparison.OrdinalIgnoreCase));
    }

    public void MostrarAniversariantesDoMes(int mesAlvo)
    {
        // Obtém o mês atual
        int mesAtual = DateTime.Now.Month;

        // Filtra médicos cujo aniversário é no mês informado
        var medicosAniversariantes = medicos
            .Where(medico => ObterMesAniversario(medico.DataDeNascimento) == mesAlvo)
            .ToList();

        // Filtra pacientes cujo aniversário é no mês informado
        var pacientesAniversariantes = pacientes
            .Where(paciente => ObterMesAniversario(paciente.DataDeNascimento) == mesAlvo)
            .ToList();

        // Exibe os médicos aniversariantes
        Console.WriteLine($"\nMédicos aniversariantes do mês {mesAlvo}:");
        foreach (var medico in medicosAniversariantes)
        {
            Console.WriteLine($"Nome: {medico.Nome}, Aniversário: {medico.DataDeNascimento}");
        }

        // Exibe os pacientes aniversariantes
        Console.WriteLine($"Pacientes aniversariantes do mês {mesAlvo}:");
        foreach (var paciente in pacientesAniversariantes)
        {
            Console.WriteLine($"Nome: {paciente.Nome}, Aniversário: {paciente.DataDeNascimento}");
        }
    }

    private int ObterMesAniversario(string dataNascimento)
    {
        DateTime data = DateTime.Parse(dataNascimento);
        return data.Month;
    }


    private int CalcularIdade(string anoNascimento)
    {
        int anoAtual = DateTime.Now.Year;
        return anoAtual - int.Parse(anoNascimento.Split('/')[2]);
    }
}
