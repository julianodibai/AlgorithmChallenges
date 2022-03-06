using static System.Console;
public class Import
{
    public void Reader(string path)
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