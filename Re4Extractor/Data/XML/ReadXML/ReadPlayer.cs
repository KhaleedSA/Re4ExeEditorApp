namespace Re4ExeEditor.Data.XML.ReadXML
{
    public class ReadPlayer
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryWriter bw = new(fs);
        private static readonly XmlTextReader xmReadPlayer = new($@"{path}\bio4\Player\Player.xml");

        public void Player()
        {
            var playerArray = Enum.GetValues(typeof(Enums.PlayerHp));

            for (int i = 0; i < playerArray.Length; i++)
            {
                while (xmReadPlayer.Read())
                {
                    if (xmReadPlayer.NodeType == XmlNodeType.Element && xmReadPlayer.Name == "Health")
                    {
                        bw.BaseStream.Seek(Convert.ToInt64(playerArray.GetValue(i)) + 1, SeekOrigin.Begin);

                        int Value = Convert.ToInt32(xmReadPlayer.GetAttribute("Value"));

                        bw.Write(Value);
                        break;
                    }
                }
                xmReadPlayer.Read();
            }
            fs.Close();
            xmReadPlayer.Close();
            bw.Close();
        }
    }
}
