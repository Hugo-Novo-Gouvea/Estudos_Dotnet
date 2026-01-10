public class Cliente
{
    public string? Nome;
    public string? Cpf;
    private decimal? Saldo;

    public Cliente(string nomeInicial, string cpfInicial)
    {
        this.Nome = nomeInicial;
        this.Cpf = cpfInicial;
        this.Saldo = 0;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Cliente: {this.Nome} | Saldo: {this.Saldo:C}");
    }

    public void Depositar(decimal valor)
    {
        if(valor > 0)
        {
            this.Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Valor de depósito inválido.");   
        }
    }

    public void Sacar(decimal valor)
    {
        if(valor > 0 && valor <= this.Saldo)
        {
            this.Saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor inválido.");
        }
    }
}
