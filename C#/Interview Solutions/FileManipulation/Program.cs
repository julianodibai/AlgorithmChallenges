using static System.Console;

var path = Path.Combine(Environment.CurrentDirectory,
                         "Entrada", "usuarios-exportacao.csv");

var import = new Import();
import.Reader(path);
