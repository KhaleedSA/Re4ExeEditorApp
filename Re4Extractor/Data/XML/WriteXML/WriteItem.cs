namespace Re4ExeEditor.Data.XML.WriteXML
{
    public class WriteItem
    {
        private static readonly string path = Directory.GetCurrentDirectory();

        public void ItemPrice()
        {
            XDocument itemLeonData = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("OTP section is a boolean [0) as false | 1) as true].\n" +
               "All values are in [Decimal type] check ItemID.txt for item ID.\n" +
               "OTP) stands for [One Time Purchase]"),

               new XElement("Class", 
                               new XAttribute("Type", "Item"),
                               new XAttribute("Target", "Shop"),
                               new XAttribute("Count", ItemArray.GetItemLeonArray().Length),
                   from iArr in ItemArray.GetItemLeonArray()
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
            itemLeonData.Save($@"{path}\bio4\Item\Prices\Leon.xml");

            XDocument itemAdaData = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("OTP section is a boolean [0) as false | 1) as true].\n" +
               "All values are in [Decimal type] check ItemID.txt for item ID.\n" +
               "OTP) stands for [One Time Purchase]"),

               new XElement("Class",
                               new XAttribute("Type", "Item"),
                               new XAttribute("Target", "Shop"),
                               new XAttribute("Count", ItemArray.GetItemAdaArray().Length),
                   from iArr in ItemArray.GetItemAdaArray()
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
            itemAdaData.Save($@"{path}\bio4\Item\Prices\Ada.xml");
        }

        public void ItemCombine()
        {
            XDocument CombineData = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("All values are in [Decimal type] check ItemID.txt for item ID"),

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

               new XComment("All values are in [Decimal type] check ItemID.txt for item ID"),

               new XElement("Class",
                               new XAttribute("Type", "Item"),
                               new XAttribute("Target", "Shop"),
                               new XAttribute("Count", StockArray.GetStockArray().Length),
                   from stockArray in StockArray.GetStockArray()
                   select new XElement("iClass",
                          new XElement("Item",
                               new XAttribute("Name", $"{stockArray.Name}"),
                               new XAttribute("Offset", stockArray.Offset.ToString("X2")),
                          new XElement("Type",
                               new XAttribute("T1", "ushort"),
                               new XAttribute("T2", "short"),
                          new XElement("Stock",
                               new XAttribute("ID", stockArray.Id),
                               new XAttribute("Quantity", stockArray.Amount)))))));
            StockData.Save($@"{path}\bio4\Item\ItemStock.xml");
        }
        
        public void ItemStack()
        {
            XDocument StackData = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("All values are in [Decimal type] check ItemID.txt for item ID \n" +
               "You can't change Ammo Type. \n" +
               "Max Stack Value is [999]"),

               new XElement("Class",
                               new XAttribute("Type", "Item"),
                               new XAttribute("Target", "Inventory"),
                               new XAttribute("Count", AmmoStackArray.GetAmmoStackArray().Length),
                   from stackArray in AmmoStackArray.GetAmmoStackArray()
                   select new XElement("iClass",
                          new XElement("Item",
                               new XAttribute("Name", $"{stackArray.Name}"),
                               new XAttribute("Offset", stackArray.Offset.ToString("X2")),
                          new XElement("Type",
                               new XAttribute("T1", "short"),
                          new XElement("Stack",
                               new XAttribute("Amount", stackArray.Stack)))))));
            StackData.Save($@"{path}\bio4\Item\AmmoStack.xml");
        }
    }
}
