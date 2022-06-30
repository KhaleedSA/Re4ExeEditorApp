namespace Re4ExeEditor.Data.XML.ReadXML
{
    public class ReadHealing
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryWriter bw = new(fs);
        private static readonly XmlTextReader xmReadHealing = new($@"{path}\bio4\Item\Healing.xml");
        private static readonly ushort maxValue = 65535;
        public void Healing()
        {
            var healingArray = Enum.GetValues(typeof(Enums.HealingEffects));

            for(int i = 0; i <=healingArray.Length; i++)
            {
                while (xmReadHealing.Read())
                {
                    if (xmReadHealing.NodeType == XmlNodeType.Element && xmReadHealing.Name == "Amount")
                    {
                        var value = Convert.ToUInt16(xmReadHealing.GetAttribute("Value"));

                        bw.BaseStream.Seek(Convert.ToInt64(healingArray.GetValue(i)) + 1, SeekOrigin.Begin);

                        if (value >= maxValue)
                        {
                            bw.Write(maxValue);
                            break;
                        }
                        else
                        {
                            bw.Write(value);
                            break;
                        }
                    }
                }
                xmReadHealing.Read();
            }
            fs.Close();
            xmReadHealing.Close();
            bw.Close();
        }
    }
}
