Title = "Re4_Exe_Editor by Khaled-SA";

WriteXml writeXml = new();
ReadXml readXml = new();

string path = $@"{Directory.GetCurrentDirectory()}\bio4.exe";
string creatPath = Directory.GetCurrentDirectory();
FileStream fs = new(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
BinaryReader br = new(fs);

try
{
    if (File.Exists(path))
    {
        WriteLine("Please insert Number... \n[ 1) Extract Xml || 2) Write exe || 3) Exit]");
        WriteLine();
        string userInput = ReadLine().Trim();
        bool looping = true;

        br.BaseStream.Position = (int)Enums.UsefulLocations.GameVersion;
        long exeVersion = br.ReadInt64();

        fs.Flush();
        fs.Close();
        br.Close();
        while (looping)
        {
            if (userInput == "1" && exeVersion == 232703143473)
            {
                Directory.CreateDirectory($@"{creatPath}\bio4");
                Directory.CreateDirectory($@"{creatPath}\bio4\Player");
                Directory.CreateDirectory($@"{creatPath}\bio4\Item\Prices");
                Directory.CreateDirectory($@"{creatPath}\bio4\Weapons");
                Directory.CreateDirectory($@"{creatPath}\bio4\Custom");
                writeXml.WriteAllXml();
                WriteLine("Xml has been extracted.");
                looping = false;
                ReadKey();
            }
            else if (userInput == "2" && File.Exists(path))
            {
                readXml.ReadAllXml();
                WriteLine("All Values has been written into exe.");
                looping = false;
                ReadKey();

            }
            else if (userInput == "3")
            {
                Environment.Exit(0);
                looping = false;
            }
            else
            {
                WriteLine();
                WriteLine("Something went Wrong!!\n" +
                    "Please Check if Exe[bio4.exe V1.0.6] is Exists in the tool path or \n" +
                    "insert a valid Number \n[ 1) Extract Xml || 2) Write exe || 3) Exit]");
                WriteLine();
                userInput = ReadLine().Trim();
            }
        }
    }
    else
    {
        WriteLine();
        WriteLine("Exe [bio4.exe V1.0.6] Not Found!!");
        ReadKey();
    }
}
catch (Exception ex)
{
    Logger.WriteLog($"error: {ex.Message}");
}


