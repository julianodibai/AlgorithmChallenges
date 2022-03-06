namespace FileManipulation
{
    public class ProgramFile
    {
        static void Main()
        {
            var import = new ImportCsv();
            import.Reader();

            var export = new ExportCsv();
            export.CreateCsv();

        }
    }

}
