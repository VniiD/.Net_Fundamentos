
int a = 5;
int b = 2;

int c = a + b;

Console.WriteLine(
					$"o valor da variavel a : {a} \n" +
					$"o valor da variavel b : {b} \n" +
					$"a soma de ambos em c é : {c} \n"
				);

c += 5;
Console.WriteLine($"adição direta no operador de atribuição += : {c}");

c -= 2;
Console.WriteLine($"subtração direta no operador de atribuição -= : {c}");

c *= 5;
Console.WriteLine($"multiplicação direta no operador de atribuição *= : {c}");

c /= 2;
Console.WriteLine($"divisão direta no operador de atribuição /= : {c} \n");


// Cast, Casting
int x = Convert.ToInt32("5"); 
// "5" por estar em aspas duplas o cinco se torna uma string
// a função Convert segue a seguinte estrutura, Convert.TipoDeConverção(valor a ser convertido)
Console.WriteLine($"o valor de x do tipo int convertera o valor atribuido em string ´5´ em int: {x}");

int y = int.Parse("2");
Console.WriteLine($"casting direto com a tipagem de conversão Parse: {y}");

// Convert ou Parse
// Convert retorna 0 quando encontra null
// Já parse encerra o programa

int i = 5;
string n = i.ToString();
// Tostring() faz a conversão para string função padrão do C#
Console.WriteLine($"casting direto com a tipagem de conversão String com ToString: {i} \n");



//Casting Implicito
short init = short.MaxValue;
Console.WriteLine($"valor MAX de short {init}");
int cast = init;
int castN = int.MaxValue;
double implicito = castN;
Console.WriteLine($"valor MAX de int {init}");
long testeN = castN;

Console.WriteLine($"cast implicito de short, {init} para int: {cast}");
Console.WriteLine($"cast implicito de int, {castN} para double: {implicito}");
Console.WriteLine($"cast implicito de int, {castN} para long: {testeN} \n");

// Logo, short converte para int que converte para double que convert para long

// Conversão segura !!!
//utilização do TryParse

string tst = "15"; //testar com "15-"

int k = 0; // podemos retirar esta variavel e introduzir diretamente no TryParse

int.TryParse(tst, out k); //Ficando assim : int.TryParse(tst, out int k)

Console.WriteLine($"Retorno da Saida {k}");

//  Em suma prepara uma saida caso a conversão nào seja realizada 