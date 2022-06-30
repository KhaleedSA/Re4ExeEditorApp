namespace Re4ExeEditor.Data.XML.ReadXML
{
    public class ReadItem
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryWriter bw = new(fs);
        private static readonly XmlTextReader xmReadLeonPrice = new($@"{path}\bio4\Item\Prices\Leon.xml");
        private static readonly XmlTextReader xmReadAdaPrice = new($@"{path}\bio4\Item\Prices\Ada.xml");
        private static readonly XmlTextReader xmReadAmmoStack = new($@"{path}\bio4\Item\AmmoStack.xml");
        private static readonly XmlTextReader xmReadCombine = new($@"{path}\bio4\Item\Combine.xml");
        private static readonly XmlTextReader xmReadStock = new($@"{path}\bio4\Item\ItemStock.xml");
        private readonly int fixedValue = 655350;
        private readonly short fixedValueStack = 999;

        public void ItemPrice()
        {
            bw.BaseStream.Position = (int)Enums.UsefulLocations.ItemsPrice_Leon;

            while (xmReadLeonPrice.Read())
            {
                if (xmReadLeonPrice.NodeType == XmlNodeType.Element && xmReadLeonPrice.Name == "Item")
                {
                    ushort id = Convert.ToUInt16(xmReadLeonPrice.GetAttribute("ID"));
                    bw.Write(id);
                }

                if (xmReadLeonPrice.NodeType == XmlNodeType.Element && xmReadLeonPrice.Name == "Value")
                {
                    int price = Convert.ToInt32(xmReadLeonPrice.GetAttribute("Price"));
                    byte otp = Convert.ToByte(xmReadLeonPrice.GetAttribute("OTP"));

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

            bw.BaseStream.Position = (int)Enums.UsefulLocations.ItemsPrice_Ada;

            while (xmReadAdaPrice.Read())
            {
                if (xmReadAdaPrice.NodeType == XmlNodeType.Element && xmReadAdaPrice.Name == "Item")
                {
                    ushort id = Convert.ToUInt16(xmReadAdaPrice.GetAttribute("ID"));
                    bw.Write(id);
                }

                if (xmReadAdaPrice.NodeType == XmlNodeType.Element && xmReadAdaPrice.Name == "Value")
                {
                    int price = Convert.ToInt32(xmReadAdaPrice.GetAttribute("Price"));
                    byte otp = Convert.ToByte(xmReadAdaPrice.GetAttribute("OTP"));

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

        public void AmmoStack()
        {
            var posArray = Enum.GetValues(typeof(Enums.AmmoStackLocation));

            for (int i = 0; i < posArray.Length; i++)
            {
                while (xmReadAmmoStack.Read())
                {
                    if (xmReadAmmoStack.NodeType == XmlNodeType.Element && xmReadAmmoStack.Name == "Stack")
                    {
                        bw.BaseStream.Seek(Convert.ToInt64(posArray.GetValue(i)), SeekOrigin.Begin);

                        short Stack = Convert.ToInt16(xmReadAmmoStack.GetAttribute("Amount"));

                        if (Stack >= fixedValueStack)
                        {
                            bw.Write(fixedValueStack);
                            break;
                        }
                        else
                        {
                            bw.Write(Stack);
                            break;
                        }
                    }
                }
                xmReadAmmoStack.Read();
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
