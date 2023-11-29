using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");


List<Paciente> pacientes = new List<Paciente>();

List<string> _sintomas = new() { "Dor de Cabeça", "Febre" };
Paciente paciente01 = new Paciente();
paciente01.Nome = "Eduardo";
paciente01.DataDeNascimento = "08/05/1996";
paciente01.Cpf = "12345678910";
paciente01.Sexo = "masculino";
paciente01.Sintomas = _sintomas;

paciente01.adicionarPaciente(paciente01, pacientes);


List<string> sintomas1 = new() { "Dor de Garganta", "Tosse" };
Paciente paciente02 = new Paciente();
paciente02.Nome = "Maria";
paciente02.DataDeNascimento = "17/11/1985";
paciente02.Cpf = "98765432101";
paciente02.Sexo = "feminino";
paciente02.Sintomas = sintomas1;

paciente02.adicionarPaciente(paciente02, pacientes);


List<string> sintomas2 = new() { "Dor nas Costas", "Cansaço" };
Paciente paciente03 = new Paciente();
paciente03.Nome = "Carlos";
paciente03.DataDeNascimento = "12/07/1990";
paciente03.Cpf = "23456789012";
paciente03.Sexo = "masculino";
paciente03.Sintomas = sintomas2;

paciente03.adicionarPaciente(paciente03, pacientes);

List<string> sintomas3 = new() { "Náusea", "Vômito" };
Paciente paciente04 = new Paciente();
paciente04.Nome = "Ana";
paciente04.DataDeNascimento = "02/02/1978";
paciente04.Cpf = "34567890123";
paciente04.Sexo = "feminino";
paciente04.Sintomas = sintomas3;

paciente04.adicionarPaciente(paciente04, pacientes);

List<string> sintomas4 = new() { "Dor Abdominal", "Diarréia" };
Paciente paciente05 = new Paciente();
paciente05.Nome = "José";
paciente05.DataDeNascimento = "03/03/1982";
paciente05.Cpf = "45678901234";
paciente05.Sexo = "masculino";
paciente05.Sintomas = sintomas4;

paciente05.adicionarPaciente(paciente05, pacientes);

// Criando Lista de medicos: 

List<Medico> medicos = new List<Medico>();

Medico medico01 = new Medico();
medico01.Nome = "Marcelo";
medico01.DataDeNascimento = "01/02/1990";
medico01.Cpf = "12345678910";
medico01.Crm = "1234";

medico01.adicionarMedico(medico01, medicos);

Medico medico02 = new Medico();
medico02.Nome = "Carolina";
medico02.DataDeNascimento = "08/12/1985";
medico02.Cpf = "23456789012";
medico02.Crm = "5678";

medico02.adicionarMedico(medico02, medicos);

Medico medico03 = new Medico();
medico03.Nome = "Antonio";
medico03.DataDeNascimento = "27/04/1978";
medico03.Cpf = "34567890123";
medico03.Crm = "9012";

medico03.adicionarMedico(medico03, medicos);

Medico medico04 = new Medico();
medico04.Nome = "Isabela";
medico04.DataDeNascimento = "22/09/1993";
medico04.Cpf = "45678901234";
medico04.Crm = "3456";

medico04.adicionarMedico(medico04, medicos);

Medico medico05 = new Medico();
medico05.Nome = "Roberto";
medico05.DataDeNascimento = "11/02/1980";
medico05.Cpf = "56789012345";
medico05.Crm = "7890";

medico05.adicionarMedico(medico05, medicos);

Relatorio relatorio = new Relatorio(pacientes, medicos);

relatorio.mostrarMedicosPorIdade(18, 40);
relatorio.MostrarPacientesPorIdade(18,100);
relatorio.MostrarPacientesPorGenero("masculino");
relatorio.MostrarAniversariantesDoMes(05);









