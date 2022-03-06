
namespace FileManipulation
{
    public class ExportCsv
    {
        string path = Path.Combine(Environment.CurrentDirectory,
                             "Saida"
                                    );

        public void CreateCsv()
        {
            var pessoas = new List<Pessoa>()
            {
                new Pessoa()
                {
                    Nome = "Ciclaninho",
                    Email = "Ciclaninho@gmail.com",
                    Telefone = 7399059682,
                    Nascimento = new DateOnly(year: 1996, month: 2, day: 05)
                },

                new Pessoa()
                {
                    Nome = "Jeregutango",
                    Email = "Jeregutango@gmail.com",
                    Telefone = 7399077775,
                    Nascimento = new DateOnly(year: 1992, month: 6, day: 20)
                },
                                new Pessoa()
                {
                    Nome = "Jhin",
                    Email = "Jhin@gmail.com",
                    Telefone = 4444444444,
                    Nascimento = new DateOnly(year: 1994, month: 4, day: 04)
                }
            };

            var dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
                path = Path.Combine(path, "usuarios.csv");
            }

            Writer(pessoas);
        }

        private void Writer(List<Pessoa> pessoas)
        {
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine("nome,email,telefone,nascimento");

                foreach (var pessoa in pessoas)
                {
                    var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
                    sw.WriteLine(linha);
                }
            }
        }

    }
}

