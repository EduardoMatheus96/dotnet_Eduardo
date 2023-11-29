// List<Medico> medicos = new List<Medico>();
List<Paciente> pacientes = new List<Paciente>();

List<string> _sintomas = new() {"Dor de Cabeça", "Febre"};
pacientes.Add(new Paciente("Eduardo", "1996", "12345678910", "masculino", _sintomas ));

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


