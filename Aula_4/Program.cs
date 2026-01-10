using System.Collections.Generic;

List<Cliente> listaDoBanco = new List<Cliente>();

listaDoBanco.Add(new Cliente("Hugo", "111.222.333-44"));
listaDoBanco.Add(new Cliente("Ana", "222.222.222-22"));
listaDoBanco.Add(new Cliente("Pedro", "333.333.333-33"));

listaDoBanco[0].Depositar(500);
listaDoBanco[1].Depositar(2000);

Console.WriteLine("============================");
Console.WriteLine("==== RELATÓRIO DO BANCO ====");
Console.WriteLine("============================");

foreach(Cliente objCliente in listaDoBanco)
{
    objCliente.ExibirDados();
}
