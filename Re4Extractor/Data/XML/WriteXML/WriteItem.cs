namespace Re4ExeExtractor.Data.XML.WriteXML
{
    public class WriteItem
    {
        private static readonly string path = Directory.GetCurrentDirectory();

        public void ItemPrice()
        {
            XDocument itemData = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("OTP section is a boolean [0) as false | 1) as true].\n" +
               "All values are in [Decimal type] check ReadMe.txt for item ID.\n" +
               "OTP) stands for [One Time Purchase]"),

               new XElement("Class", 
                               new XAttribute("Type", "Item"),
                               new XAttribute("Target", "Shop"),
                               new XAttribute("Count", ItemArray.GetItemArray().Length),
                   from iArr in ItemArray.GetItemArray()
                   select new XElement("iClass",
                          new XElement("Item",
                               new XAttribute("Name", iArr.Name),
                               new XAttribute("ID", iArr.Id),
                               new XAttribute("Offset", iArr.Offset.ToString("X2")),
                          new XElement("Type",
                               new XAttribute("T1", "int"),
                               new XAttribute("T2", "byte"),
                          new XElement("Value",
                               new XAttribute("Price", $"{iArr.Price * 10}"),
                               new XAttribute("OTP", iArr.OTP)))))));
            itemData.Save($@"{path}\bio4\Item\Price.xml");
        }

        public void ItemCombine()
        {
            XDocument CombineData = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("All values are in [Decimal type] check ReadMe.txt for item ID"),

               new XElement("Class",
                               new XAttribute("Type", "Item"),
                               new XAttribute("Target", "Inventory"),
                               new XAttribute("Count", CombineArray.GetCombineArrays().Length),
                               new XElement("iClass",
                          new XElement("Item",
                          new XElement("Combination",
                               new XAttribute("T1", "ushort"),
                               new XAttribute("T2", "ushort"),
                               new XAttribute("T3", "ushort"),
                   from coArr in CombineArray.GetCombineArrays()
                   select new XElement("Group",
                               new XAttribute("Set1", coArr.Id1),
                               new XAttribute("Set2", coArr.Id2),
                               new XAttribute("Result", coArr.Result),
                               new XAttribute("Offset", coArr.Offset.ToString("X2"))))))));
            CombineData.Save($@"{path}\bio4\Item\Combine.xml");
        }

        public void ItemStock()
        {
            XDocument StockData = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("All values are in [Decimal type] check ReadMe.txt for item ID"),

               new XElement("Class",
                               new XAttribute("Type", "Item"),
                               new XAttribute("Target", "Shop"),
                               new XAttribute("Count", StockArray.GetStockArray().Length),
                   from stArry in StockArray.GetStockArray()
                   select new XElement("iClass",
                          new XElement("Item",
                               new XAttribute("Name", $"{stArry.Name}"),
                               new XAttribute("Offset", stArry.Offset.ToString("X2")),
                          new XElement("Type",
                               new XAttribute("T1", "ushort"),
                               new XAttribute("T2", "short"),
                          new XElement("Stock",
                               new XAttribute("ID", stArry.Id),
                               new XAttribute("Quantity", stArry.Amount)))))));
            StockData.Save($@"{path}\bio4\Item\Stock.xml");
        }
    }
}
