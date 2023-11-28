var estoque = new List<(int id, string name, int amount, decimal price)>{};

Dictionary<string, Action> menuSwitch = new Dictionary<string, Action> () {
    {"1", register},
    {"2", search},
    {"3", list},
    {"4", refresh},
    {"5", GenerateReports},
    {"6", exit},
};

void register(){
    int id;
    int amount;
    string name;
    decimal price;

    try
    {
        Console.WriteLine("\n Cadastrar novo produto: ");
        Console.Write("ID: ");
        id = int.Parse(Console.ReadLine());

        Console.Write("Nome: ");
        name = Console.ReadLine();

        Console.Write("Quantidade: ");
        amount = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        price = decimal.Parse(Console.ReadLine());

        estoque.Add((id, name, amount, price));
    }
    catch (FormatException)
        {
            Console.WriteLine("Erro: Entrada inválida. Certifique-se de inserir um valor numérico para aquantidade e preço.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    
};

void search()
{
    Console.WriteLine("Informe o Código do produto que deseja encontrar: ");
    int codigo = int.Parse(Console.ReadLine());

    try
    {
        var produto = estoque.First(p => p.id == codigo);

        Console.WriteLine($"Produto encontrado:\nCódigo: {produto.id}\nNome: {produto.name}\nQuantidade: {produto.amount}\nPreço Unitário: {produto.price:C}");
    }
    catch (InvalidOperationException)
    {
        Console.WriteLine("Código de produto não encontrado!");
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: Entrada inválida. Certifique-se de inserir um valor numérico para o código do produto.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro inesperado: {ex.Message}");
    }
}

void refresh()
{
    Console.WriteLine("Informe o Código do produto que deseja atualizar: ");
    int codigo = int.Parse(Console.ReadLine());

    try
    {
        // Encontrar o índice do produto na lista
        int index = -1;
        for (int i = 0; i < estoque.Count; i++)
        {
            if (estoque[i].id == codigo)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            Console.Write("Informe a quantidade a ser adicionada (positiva) ou removida (negativa): ");
            int quantidadeAtualizacao = int.Parse(Console.ReadLine());

            // Atualizar a quantidade no estoque
            if (estoque[index].amount + quantidadeAtualizacao < 0)
            {
                Console.WriteLine("Erro: Quantidade insuficiente para remoção.");
            }
            else
            {
                // Atualizar a quantidade na lista
                estoque[index] = (estoque[index].id, estoque[index].name, estoque[index].amount + quantidadeAtualizacao, estoque[index].price);
                Console.WriteLine("Estoque atualizado com sucesso.");
            }
        }
        else
        {
            Console.WriteLine("Código de produto não encontrado!");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: Entrada inválida. Certifique-se de inserir valores numéricos para código e quantidade.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro inesperado: {ex.Message}");
    }
}

void list(){
    foreach (var item in estoque)
    {
        Console.WriteLine(item);
    }
};

void GenerateReports()
    {
        // Relatório 1: Lista de produtos com quantidade em estoque abaixo de um limite informado pelo usuário.
        Console.Write("Informe o limite de quantidade para o relatório 1: ");
        int limiteQuantidade = int.Parse(Console.ReadLine());
        var relatorio1 = estoque.Where(p => p.amount < limiteQuantidade);

        Console.WriteLine("\nRelatório 1: Produtos com quantidade em estoque abaixo do limite:");
        foreach (var produto in relatorio1)
        {
            Console.WriteLine($"ID: {produto.id} - Nome: {produto.name} - Quantidade: {produto.amount} - Preço: {produto.price:C}");
        }

        // Relatório 2: Lista de produtos com valor entre um mínimo e um máximo informados pelo usuário.
        Console.Write("\nInforme o valor mínimo para o relatório 2: ");
        decimal valorMinimo = decimal.Parse(Console.ReadLine());
        Console.Write("Informe o valor máximo para o relatório 2: ");
        decimal valorMaximo = decimal.Parse(Console.ReadLine());
        var relatorio2 = estoque.Where(p => p.price >= valorMinimo && p.price <= valorMaximo);

        Console.WriteLine("\nRelatório 2: Produtos com valor entre o mínimo e o máximo:");
        foreach (var produto in relatorio2)
        {
            Console.WriteLine($"ID: {produto.id} - Nome: {produto.name} - Quantidade: {produto.amount} - Preço: {produto.price:C}");
        }

        // Relatório 3: Informar o valor total do estoque e o valor total de cada produto de acordo com seu estoque.
        decimal valorTotalEstoque = estoque.Sum(p => p.amount * p.price);

        Console.WriteLine($"\nRelatório 3: Valor total do estoque: {valorTotalEstoque:C}");
        Console.WriteLine("Valor total de cada produto de acordo com seu estoque:");
        foreach (var produto in estoque)
        {
            decimal valorTotalProduto = produto.amount * produto.price;
            Console.WriteLine($"ID: {produto.id} - Nome: {produto.name} - Valor Total: {valorTotalProduto:C}");
        }
    }

void exit(){
    Environment.Exit(0);
};

do
{
    Console.WriteLine("Selecione uma das seguintes opções: ");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Busca pelo Id");
    Console.WriteLine("3 - Listar");
    Console.WriteLine("4 - Atualizar Estoque");
    Console.WriteLine("5 - Gerar Relatórios");
    Console.WriteLine("6 - Sair");

    var opcao = Console.ReadLine();

    try
    {
        menuSwitch[opcao]?.Invoke();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Opção Invalida. Digite um numero entre 1 e 6.");
    }

} while (true);

