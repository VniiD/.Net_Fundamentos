// Tipos

string	boasVindas = "Olá, seja bem vindo!";
int 	quantidade = 42;
double	altura = 1.80;
decimal	valor = 1.02M;
bool	condicao = true;

Console.WriteLine(boasVindas + "\n");
Console.WriteLine("Valor da variavel qtd:		" + quantidade);
Console.WriteLine("Valor da variavel altura:	" + altura); // Para tratamento manual altura.ToString("0.00")
Console.WriteLine("Valor da variavel valor:	" + valor);
Console.WriteLine("Valor da variavel condicao:	" + condicao + "\n");

// Variaveis
// Tipo Nome = Valor;

int exemplo = 1; // Foi instanciada 
Console.WriteLine("Valor da variavel exemplo:	" + exemplo);

exemplo = 10; // Já foi instanciada e esta no mesmo escopo não é necessario tipar novamente!
Console.WriteLine("Valor da variavel exemplo sobrescrita:	" + exemplo + "\n");
