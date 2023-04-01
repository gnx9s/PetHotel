Console.WriteLine("--- Pet Hotel ---\n");

Console.Write("Espécie......: ");
string especie = Console.ReadLine()!;

Console.Write("Raça.........: ");
string raca = Console.ReadLine()!;

Console.Write("Nome (Apelido)......: ");
string nome = Console.ReadLine()!;

Console.Write("Idade (anos).: ");
string idade = Console.ReadLine()!;

Console.Write("Pelagem/cor..: ");
string pelagem = Console.ReadLine()!;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+==========================================================+");
Console.Write("|                 ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("       Pet Hotel");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("                         |");
Console.WriteLine("+==========================================================+");

Console.Write("| Espécie: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = ConsoleColor.DarkGray;

Console.Write(" | Raça: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(raca.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.ForegroundColor = ConsoleColor.DarkGray;

Console.WriteLine(" |");

Console.Write("| Apelido: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(nome.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = ConsoleColor.DarkGray;

Console.Write(" | Idade: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(idade.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.Write("| Pelagem: ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(pelagem.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = ConsoleColor.DarkGray;

Console.WriteLine(" |");
Console.WriteLine("+==========================================================+");


