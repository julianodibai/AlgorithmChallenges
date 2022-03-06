using static System.Console;

namespace FileManipulation
{
    public class ImportCsv
    {
        string path = Path.Combine(Environment.CurrentDirectory,
                             "Entrada", "usuarios-exportacao.csv");

        public void Reader()
        {
            if (File.Exists(path))
            {
                using (var sr = new StreamReader(path))
                {
                    var header = sr.ReadLine()?.Split(',');
                    while (true)
                    {
                        var body = sr.ReadLine()?.Split(',');
                        if (body == null)
                            break;
                        for (int i = 0; i < body.Length; i++)
                        {
                            WriteLine($"{header?[i]}: {body[i]}");
                        }

                        WriteLine("---------------------------------------");
                    }
                    WriteLine("Pressione [Enter] para finalizar");
                    ReadLine();
                }
            }
        }
    }
}