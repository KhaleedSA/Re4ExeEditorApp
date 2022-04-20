namespace Re4ExeExtractor.Data.XML.ReadXML
{
    public class ReadHealing
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryWriter bw = new(fs);
        private static readonly XmlTextReader xmReadHealing = new($@"{path}\bio4\Item\Healing.xml");

        public void Healing()
        {
            xmReadHealing.Read();

            while (xmReadHealing.Read())
            {
                if (xmReadHealing.NodeType == XmlNodeType.Element && xmReadHealing.Name == "Item")
                {
                    var healingType = xmReadHealing.GetAttribute("Name");

                    if (healingType == $"{Enums.HealingEffects.MixedHerb:G}")
                    {
                        while (xmReadHealing.Read())
                        {
                            if (xmReadHealing.NodeType == XmlNodeType.Element && xmReadHealing.Name == "Amount")
                            {
                                int value1 = Convert.ToInt32(xmReadHealing.GetAttribute("Value"));
                                bw.BaseStream.Position = (int)Enums.HealingEffects.MixedHerb;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(value1));
                                break;
                            }
                        }
                    }
                    if (healingType == $"{Enums.HealingEffects.Unk0:G}")
                    {
                        while (xmReadHealing.Read())
                        {
                            if (xmReadHealing.NodeType == XmlNodeType.Element && xmReadHealing.Name == "Amount")
                            {
                                int value2 = Convert.ToInt32(xmReadHealing.GetAttribute("Value"));
                                bw.BaseStream.Position = (int)Enums.HealingEffects.Unk0;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(value2));
                                break;
                            }
                        }
                    }
                    if (healingType == $"{Enums.HealingEffects.WhiteEgg:G}")
                    {
                        while (xmReadHealing.Read())
                        {
                            if (xmReadHealing.NodeType == XmlNodeType.Element && xmReadHealing.Name == "Amount")
                            {
                                int value3 = Convert.ToInt32(xmReadHealing.GetAttribute("Value"));
                                bw.BaseStream.Position = (int)Enums.HealingEffects.WhiteEgg;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(value3));
                                break;
                            }
                        }
                    }
                    if (healingType == $"{Enums.HealingEffects.BrownEgg:G}")
                    {
                        while (xmReadHealing.Read())
                        {
                            if (xmReadHealing.NodeType == XmlNodeType.Element && xmReadHealing.Name == "Amount")
                            {
                                int value4 = Convert.ToInt32(xmReadHealing.GetAttribute("Value"));
                                bw.BaseStream.Position = (int)Enums.HealingEffects.BrownEgg;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(value4));
                                break;
                            }
                        }
                    }
                    if (healingType == $"{Enums.HealingEffects.GoldenEgg_G3_FishL:G}")
                    {
                        while (xmReadHealing.Read())
                        {
                            if (xmReadHealing.NodeType == XmlNodeType.Element && xmReadHealing.Name == "Amount")
                            {
                                int value5 = Convert.ToInt32(xmReadHealing.GetAttribute("Value"));
                                bw.BaseStream.Position = (int)Enums.HealingEffects.GoldenEgg_G3_FishL;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(value5));
                                break;
                            }
                        }
                    }
                    if (healingType == $"{Enums.HealingEffects.FirstAid_GR:G}")
                    {
                        while (xmReadHealing.Read())
                        {
                            if (xmReadHealing.NodeType == XmlNodeType.Element && xmReadHealing.Name == "Amount")
                            {
                                int value6 = Convert.ToInt32(xmReadHealing.GetAttribute("Value"));
                                bw.BaseStream.Position = (int)Enums.HealingEffects.FirstAid_GR;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(value6));
                                break;
                            }
                        }
                    }
                    if (healingType == $"{Enums.HealingEffects.FishS:G}")
                    {
                        while (xmReadHealing.Read())
                        {
                            if (xmReadHealing.NodeType == XmlNodeType.Element && xmReadHealing.Name == "Amount")
                            {
                                int value7 = Convert.ToInt32(xmReadHealing.GetAttribute("Value"));
                                bw.BaseStream.Position = (int)Enums.HealingEffects.FishS;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(value7));
                                break;
                            }
                        }
                    }
                    if (healingType == $"{Enums.HealingEffects.Green:G}")
                    {
                        while (xmReadHealing.Read())
                        {
                            if (xmReadHealing.NodeType == XmlNodeType.Element && xmReadHealing.Name == "Amount")
                            {
                                int value8 = Convert.ToInt32(xmReadHealing.GetAttribute("Value"));
                                bw.BaseStream.Position = (int)Enums.HealingEffects.Green;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(value8));
                                break;
                            }
                        }
                    }
                    if (healingType == $"{Enums.HealingEffects.Green2:G}")
                    {
                        while (xmReadHealing.Read())
                        {
                            if (xmReadHealing.NodeType == XmlNodeType.Element && xmReadHealing.Name == "Amount")
                            {
                                int value9 = Convert.ToInt32(xmReadHealing.GetAttribute("Value"));
                                bw.BaseStream.Position = (int)Enums.HealingEffects.Green2;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(value9));
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            fs.Close();
            xmReadHealing.Close();
            bw.Close();
        }
    }
}
