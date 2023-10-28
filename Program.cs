Console.Clear();
Console.WriteLine("---Quadrante Cartesiano---");
Console.WriteLine("");
Console.WriteLine("Digite a coordenada X");
double X = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Digite a coordenada Y");
double Y = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("");
Console.Write("Coordenada x:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($" {X}");
Console.ResetColor();
Console.Write($"Coordenada y:");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($" {Y}");
Console.ResetColor();

string localizacao;
if (X == 0 && Y == 0 ) localizacao = " Origem";
else if (X == 0) localizacao = " Eixo das ordenadas";
else if (Y == 0) localizacao = " Eixo das abcissas";
else if (Y > 0)
{
    if (X > 0)
        localizacao = " Quadrante 1";
    else    
        localizacao = " Quadrante 2";
}
else 
{
    if (X < 0)
        localizacao = " Quadrante 3";
    else
        localizacao = " Quadrante 4";
}

Console.Write("O ponto (");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{X}");
Console.ResetColor();
Console.Write(",");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write($" {Y}");
Console.ResetColor();
Console.Write(") fica no");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"{localizacao}");
Console.ResetColor();