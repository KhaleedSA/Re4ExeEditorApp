namespace Re4ExeExtractor.Data.XML.ReadXML
{
    public class ReadPlayer
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryWriter bw = new(fs);
        private static readonly XmlTextReader xmReadPlayer = new($@"{path}\bio4\Player\Player.xml");

        public void Player()
        {
            xmReadPlayer.Read();

            while (xmReadPlayer.Read())
            {
                if (xmReadPlayer.NodeType == XmlNodeType.Element && xmReadPlayer.Name == "Player")
                {
                    var s1 = xmReadPlayer.GetAttribute("Name");

                    if (s1 == $"{Enums.PlayerHp.S_Leon:G}")
                    {
                        while (xmReadPlayer.Read())
                        {
                            if (xmReadPlayer.NodeType == XmlNodeType.Element && xmReadPlayer.Name == "Health")
                            {
                                var p1 = xmReadPlayer.GetAttribute("Value");
                                bw.BaseStream.Position = (int)Enums.PlayerHp.S_Leon;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(p1));
                                break;
                            }
                        }
                    }
                    if (s1 == $"{Enums.PlayerHp.M_Leon_Wesker:G}")
                    {
                        while (xmReadPlayer.Read())
                        {
                            if (xmReadPlayer.NodeType == XmlNodeType.Element && xmReadPlayer.Name == "Health")
                            {
                                var p2 = xmReadPlayer.GetAttribute("Value");
                                bw.BaseStream.Position = (int)Enums.PlayerHp.M_Leon_Wesker;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(p2));
                                break;
                            }
                        }
                    }
                    if (s1 == $"{Enums.PlayerHp.Unk1:G}")
                    {
                        while (xmReadPlayer.Read())
                        {
                            if (xmReadPlayer.NodeType == XmlNodeType.Element && xmReadPlayer.Name == "Health")
                            {
                                var p3 = xmReadPlayer.GetAttribute("Value");
                                bw.BaseStream.Position = (int)Enums.PlayerHp.Unk1;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(p3));
                                break;
                            }
                        }
                    }
                    if (s1 == $"{Enums.PlayerHp.SM_Ada:G}")
                    {
                        while (xmReadPlayer.Read())
                        {
                            if (xmReadPlayer.NodeType == XmlNodeType.Element && xmReadPlayer.Name == "Health")
                            {
                                var p4 = xmReadPlayer.GetAttribute("Value");
                                bw.BaseStream.Position = (int)Enums.PlayerHp.SM_Ada;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(p4));
                                break;
                            }
                        }
                    }
                    if (s1 == $"{Enums.PlayerHp.S_Ada:G}")
                    {
                        while (xmReadPlayer.Read())
                        {
                            if (xmReadPlayer.NodeType == XmlNodeType.Element && xmReadPlayer.Name == "Health")
                            {
                                var p5 = xmReadPlayer.GetAttribute("Value");
                                bw.BaseStream.Position = (int)Enums.PlayerHp.S_Ada;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(p5));
                                break;
                            }
                        }
                    }
                    if (s1 == $"{Enums.PlayerHp.Unk2:G}")
                    {
                        while (xmReadPlayer.Read())
                        {
                            if (xmReadPlayer.NodeType == XmlNodeType.Element && xmReadPlayer.Name == "Health")
                            {
                                var p6 = xmReadPlayer.GetAttribute("Value");
                                bw.BaseStream.Position = (int)Enums.PlayerHp.Unk2;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(p6));
                                break;
                            }
                        }
                    }
                    if (s1 == $"{Enums.PlayerHp.M_Hunk:G}")
                    {
                        while (xmReadPlayer.Read())
                        {
                            if (xmReadPlayer.NodeType == XmlNodeType.Element && xmReadPlayer.Name == "Health")
                            {
                                var p7 = xmReadPlayer.GetAttribute("Value");
                                bw.BaseStream.Position = (int)Enums.PlayerHp.M_Hunk;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(p7));
                                break;
                            }
                        }
                    }
                    if (s1 == $"{Enums.PlayerHp.M_Krauser:G}")
                    {
                        while (xmReadPlayer.Read())
                        {
                            if (xmReadPlayer.NodeType == XmlNodeType.Element && xmReadPlayer.Name == "Health")
                            {
                                var p8 = xmReadPlayer.GetAttribute("Value");
                                bw.BaseStream.Position = (int)Enums.PlayerHp.M_Krauser;
                                bw.Seek(1, SeekOrigin.Current);
                                bw.Write(Convert.ToInt32(p8));
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            fs.Close();
            xmReadPlayer.Close();
            bw.Close();
        }
    }
}
