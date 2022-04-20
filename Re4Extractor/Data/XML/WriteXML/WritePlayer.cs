namespace Re4ExeExtractor.Data.XML.WriteXML
{
    public class WritePlayer
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        public void Player()
        {
            XDocument playerData = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("Some Player Health Are been shared between modes.\n" +
               "Max Player Health is [32767] above that Player is considered Dead."),

               new XElement("Class", 
                          new XAttribute("Type", "Health"),
                          new XAttribute("Target", "Character"),
                          new XAttribute("Count", PlayerArray.GetPlayerArray().Length),
                   from pArr in PlayerArray.GetPlayerArray()
                   select new XElement("pClass",
                          new XElement("Player",
                               new XAttribute("Name", pArr.Name),
                               new XAttribute("Offset", pArr.Offset.ToString("X2"))),
                          new XElement("Health",
                               new XAttribute("Value", pArr.Value),
                               new XAttribute("Type", "short"))
                               )));
            playerData.Save($@"{path}\bio4\Player\Player.xml");
        }
    }
}
