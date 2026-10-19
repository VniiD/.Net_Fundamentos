// Switch Case

Console.WriteLine("Digite uma Letra:");
string letra = Console.ReadLine();

if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
{
	Console.WriteLine("Vogal");
}
else
{
	Console.WriteLine("Consoante");
}

switch (letra)
{
	case "a":
	case "e":
	case "i":
	case "o":
	case "u":
		Console.WriteLine("Vogal");
		break;
	default:
		Console.WriteLine("Consoante");
		break;
	}