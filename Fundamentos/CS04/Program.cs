DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual);

Console.WriteLine(dataAtual.ToString("dd/MM/yy"));
Console.WriteLine(dataAtual.ToString("dd/MM/yy HH:mm"));