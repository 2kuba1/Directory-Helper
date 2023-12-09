using System.Diagnostics;

var dirPath = Directory.GetCurrentDirectory();

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Black;
Console.Write($"Opening: {dirPath}");
Console.ResetColor();

var process = new Process();

process.StartInfo.FileName = "EXPLORER.EXE";
process.StartInfo.Arguments = $"/n, {dirPath}";

process.Start();