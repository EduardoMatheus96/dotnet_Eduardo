List<Paciente> pacientes = new List<Paciente>();

List<string> _sintomas = new() { "Dor de Cabeça", "Febre" };
pacientes.Add(new Paciente("Eduardo", "1996", "12345678910", "masculino", _sintomas));

List<string> sintomas1 = new() { "Dor de Garganta", "Tosse" };
pacientes.Add(new Paciente("Maria", "1985", "98765432101", "feminino", sintomas1));

List<string> sintomas2 = new() { "Dor nas Costas", "Cansaço" };
pacientes.Add(new Paciente("Carlos", "1990", "23456789012", "masculino", sintomas2));

List<string> sintomas3 = new() { "Náusea", "Vômito" };
pacientes.Add(new Paciente("Ana", "1978", "34567890123", "feminino", sintomas3));

List<string> sintomas4 = new() { "Dor Abdominal", "Diarréia" };
pacientes.Add(new Paciente("José", "1982", "45678901234", "masculino", sintomas4));

List<string> sintomas5 = new() { "Falta de Ar", "Cefaleia" };
pacientes.Add(new Paciente("Mariana", "1995", "56789012345", "feminino", sintomas5));

List<string> sintomas6 = new() { "Dor Muscular", "Dificuldade para Dormir" };
pacientes.Add(new Paciente("Lucas", "1988", "67890123456", "masculino", sintomas6));

List<string> sintomas7 = new() { "Irritabilidade", "Falta de Apetite" };
pacientes.Add(new Paciente("Camila", "1983", "78901234567", "feminino", sintomas7));

List<string> sintomas8 = new() { "Dor nos Olhos", "Sensibilidade à Luz" };
pacientes.Add(new Paciente("Rafael", "1992", "89012345678", "masculino", sintomas8));

// Criando Lista de medicos: 

List<Medico> medicos = new List<Medico>();

Medico medico01 = new Medico();
medico01.Nome = "Marcelo";
medico01.DataDeNascimento = "1990";
medico01.Cpf = "12345678910";
medico01.Crm = "1234";

medico01.adicionarMedico(medico01, medicos);

Medico medico02 = new Medico();
medico02.Nome = "Carolina";
medico02.DataDeNascimento = "1985";
medico02.Cpf = "23456789012";
medico02.Crm = "5678";

medico02.adicionarMedico(medico02, medicos);

Medico medico03 = new Medico();
medico03.Nome = "Antonio";
medico03.DataDeNascimento = "1978";
medico03.Cpf = "34567890123";
medico03.Crm = "9012";

medico03.adicionarMedico(medico03, medicos);

Medico medico04 = new Medico();
medico04.Nome = "Isabela";
medico04.DataDeNascimento = "1993";
medico04.Cpf = "45678901234";
medico04.Crm = "3456";

medico04.adicionarMedico(medico04, medicos);

Medico medico05 = new Medico();
medico05.Nome = "Roberto";
medico05.DataDeNascimento = "1980";
medico05.Cpf = "56789012345";
medico05.Crm = "7890";

medico05.adicionarMedico(medico05, medicos);










