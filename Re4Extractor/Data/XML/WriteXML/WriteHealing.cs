namespace Re4ExeExtractor.Data.XML.WriteXML
{
    public class WriteHealing
    {
        private static readonly string path = Directory.GetCurrentDirectory();

        public void Healing()
        {
            XDocument playerData = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("Some Healing items Are been shared.\n" +
               "Max healing value is [32767].\n"),

               new XElement("Class",
                          new XAttribute("Type", "Item"),
                          new XAttribute("Target", "Health"),
                          new XAttribute("Count", HealingArray.GetHealingArray().Length),
                   from hArr in HealingArray.GetHealingArray()
                   select new XElement("hClass",
                          new XElement("Item",
                               new XAttribute("Name", hArr.Name),
                               new XAttribute("Offset", hArr.Offset.ToString("X2"))),
                          new XElement("Amount",
                               new XAttribute("Value", hArr.Value),
                               new XAttribute("Type", "short"))
                               )));
            playerData.Save($@"{path}\bio4\Item\Healing.xml");
        }
    }
}
