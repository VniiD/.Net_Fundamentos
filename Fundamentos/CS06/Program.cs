// Operadores !!! 

// Ordem de execução dos operadores seguem ao padrão matematico (), /, *, -, +
Console.WriteLine("\nOrdem de execução dos operadores matematicos !");
double a = 4 / 2 + 2;
Console.WriteLine($"\nSegue o resultado da operação 4 / 2 + 2 = {a}");
double b = 4 / (2 + 2);
Console.WriteLine($"Segue o resultado da operação 4 / (2 + 2) = {b} \n");

// Operadores Concdicionais !!! -----------------------------------------------------------------------------------
// operadores de condicionais, >, >=, <, <=

Console.WriteLine("Introdução a operadores de grandesa\n");
int quantidadeEmEstoque = 3; // Teste com um valor inferior a quantidadeDaCompra
int quantidadeDaCompra = 1; // Teste com um valor 0
bool possivelVenda = quantidadeDaCompra > 0 && quantidadeDaCompra <= quantidadeEmEstoque ;

// É possivel colocar uma condicional dentro da funçào WriteLine, só que o retorno é booleano.
Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade da compra: {quantidadeDaCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");


if(quantidadeDaCompra == 0)
{
	Console.WriteLine("Compra invalida !\n");
}
else if (possivelVenda) // Condicional aninhadas!
{
	Console.WriteLine("Compra efutuada com sucesso !\n");
}
else
{
	Console.WriteLine("Dedsculpe não temos a quantidade desejada em estoque !\n");
}

// Operadores Logicos !!! -----------------------------------------------------------------------------------
// operadores logicos, &&, ||, !
// || = OU,  && = E, ! = NÃO

Console.WriteLine("Responda sim ou não !\n");
Console.Write("É maior de Idade (Sim ou não) ? ");
string respostaMaiorIdade = Console.ReadLine();

Console.Write("possui autorização (Sim ou não) ? ");
string respostaAutorizacao = Console.ReadLine();

bool ehMaiorDeIdade = respostaMaiorIdade != null && respostaMaiorIdade.Trim().Equals("Sim", StringComparison.OrdinalIgnoreCase);
bool possuiAutorizacao = respostaAutorizacao != null && respostaAutorizacao.Trim().Equals("Sim", StringComparison.OrdinalIgnoreCase);

if (ehMaiorDeIdade || possuiAutorizacao)
{
	Console.WriteLine("Entrada liberada !");
}
else
{
	Console.WriteLine("Entrada negada !");
}