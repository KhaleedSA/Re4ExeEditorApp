namespace Re4ExeExtractor.Data.XML.ReadXML
{
    public class ReadItem
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryWriter bw = new(fs);
        private static readonly XmlTextReader xmReadPrice = new($@"{path}\bio4\Item\Price.xml");
        private static readonly XmlTextReader xmReadCombine = new($@"{path}\bio4\Item\Combine.xml");
        private static readonly XmlTextReader xmReadStock = new($@"{path}\bio4\Item\Stock.xml");
        private readonly int fixedValue = 655350;
        public void ItemPrice()
        {
            bw.BaseStream.Position = (int)Enums.UsefulLocations.ItemsPrice_Leon;

            while (xmReadPrice.Read())
            {
                if (xmReadPrice.NodeType == XmlNodeType.Element && xmReadPrice.Name == "Item")
                {
                    ushort id = Convert.ToUInt16(xmReadPrice.GetAttribute("ID"));
                    bw.Write(id);
                }

                if (xmReadPrice.NodeType == XmlNodeType.Element && xmReadPrice.Name == "Value")
                {
                    int price = Convert.ToInt32(xmReadPrice.GetAttribute("Price"));
                    byte otp = Convert.ToByte(xmReadPrice.GetAttribute("OTP"));

                    if (price > fixedValue)
                    {
                        bw.Write((ushort)(fixedValue / 10));
                        bw.Write(otp);
                    }
                    else
                    {
                        bw.Write((ushort)(price / 10));
                        bw.Write(otp);
                    }
                    bw.Seek(1, SeekOrigin.Current);
                }
            }
        }

        public void ItemCombination()
        {
            bw.BaseStream.Position = (int)Enums.UsefulLocations.ItemsToCombine;

            while (xmReadCombine.Read())
            {
                if (xmReadCombine.NodeType == XmlNodeType.Element && xmReadCombine.Name == "Group")
                {
                    ushort set1 = Convert.ToUInt16(xmReadCombine.GetAttribute("Set1"));
                    ushort set2 = Convert.ToUInt16(xmReadCombine.GetAttribute("Set2"));
                    ushort result = Convert.ToUInt16(xmReadCombine.GetAttribute("Result"));

                    bw.Write(set1);
                    bw.Write(set2);
                    bw.Write(result);
                }
            }
        }

        public void ItemStock()
        {
            bw.BaseStream.Position = (int)Enums.UsefulLocations.ItemsInStock;

            while (xmReadStock.Read())
            {
                if (xmReadStock.NodeType == XmlNodeType.Element && xmReadStock.Name == "Stock")
                {
                    ushort id = Convert.ToUInt16(xmReadStock.GetAttribute("ID"));
                    ushort amount = Convert.ToUInt16(xmReadStock.GetAttribute("Quantity"));

                    bw.Write(id);
                    bw.Write(amount);
                }
            }
            fs.Flush();
            fs.Close();
            xmReadStock.Close();
            bw.Close();
        }
    }
}
