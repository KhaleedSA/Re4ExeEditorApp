namespace Re4ExeExtractor.Data.XML
{
    public class Logger
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly StreamWriter sw = new($"{path}/Log.txt", true);

        public static void WriteLog(string message)
        {
            sw.WriteLine("--------------Start--------------");
            sw.WriteLine($"{DateTime.Now}: {message}");
            sw.WriteLine("--------------End----------------");
            sw.WriteLine(" ");
            sw.Flush();
            sw.Close();
        }
    }
}
