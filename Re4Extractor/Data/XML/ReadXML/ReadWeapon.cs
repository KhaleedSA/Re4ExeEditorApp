namespace Re4ExeExtractor.Data.XML.ReadXML
{
    public class ReadWeapon
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryWriter bw = new(fs);
        private static readonly XmlTextReader xmReadWeaponStats = new($@"{path}\bio4\Weapons\Stats.xml");
        private static readonly XmlTextReader xmReadWeaponAvail = new($@"{path}\bio4\Weapons\AvailableUpgrade.xml");
        private static readonly XmlTextReader xmReadWeaponMaxLvl = new($@"{path}\bio4\Weapons\MaxLvl.xml");
        private static readonly XmlTextReader xmReadWeaponPower = new($@"{path}\bio4\Weapons\Power.xml");
        private static readonly XmlTextReader xmReadWeaponUpgradePrice = new($@"{path}\bio4\Weapons\UpgradePrice.xml");
        private static readonly float FixedFirePower = 99.9f;
        private readonly int fixedPriceValue = 327670;

        public void WeaponStats()
        {
            bw.BaseStream.Position = (int)Enums.UsefulLocations.WeapStats;

            while (xmReadWeaponStats.Read())
            {
                if (xmReadWeaponStats.NodeType == XmlNodeType.Element && xmReadWeaponStats.Name == "Weapon")
                {
                    ushort weaponID = Convert.ToUInt16(xmReadWeaponStats.GetAttribute("ID"));
                    bw.Write(weaponID);
                }
                if (xmReadWeaponStats.NodeType == XmlNodeType.Element && xmReadWeaponStats.Name == "Model")
                {
                    short modelID = Convert.ToInt16(xmReadWeaponStats.GetAttribute("ID"));
                    bw.Write(modelID);
                }
                if (xmReadWeaponStats.NodeType == XmlNodeType.Element && xmReadWeaponStats.Name == "Attachment")
                {
                    short attachmentID = Convert.ToInt16(xmReadWeaponStats.GetAttribute("ID"));
                    bw.Write(attachmentID);
                }
                if (xmReadWeaponStats.NodeType == XmlNodeType.Element && xmReadWeaponStats.Name == "Ammo")
                {
                    byte ammoID = Convert.ToByte(xmReadWeaponStats.GetAttribute("ID"));
                    bw.Write(ammoID);
                    bw.Seek(1, SeekOrigin.Current);
                }
                if (xmReadWeaponStats.NodeType == XmlNodeType.Element && xmReadWeaponStats.Name == "Lvl-1")
                {
                    ushort qty_Lvl1 = Convert.ToUInt16(xmReadWeaponStats.GetAttribute("Quantity"));
                    bw.Write(qty_Lvl1);
                }
                if (xmReadWeaponStats.NodeType == XmlNodeType.Element && xmReadWeaponStats.Name == "Lvl-2")
                {
                    ushort qty_Lvl2 = Convert.ToUInt16(xmReadWeaponStats.GetAttribute("Quantity"));
                    bw.Write(qty_Lvl2);
                }
                if (xmReadWeaponStats.NodeType == XmlNodeType.Element && xmReadWeaponStats.Name == "Lvl-3")
                {
                    ushort qty_Lvl3 = Convert.ToUInt16(xmReadWeaponStats.GetAttribute("Quantity"));
                    bw.Write(qty_Lvl3);
                }
                if (xmReadWeaponStats.NodeType == XmlNodeType.Element && xmReadWeaponStats.Name == "Lvl-4")
                {
                    ushort qty_Lvl4 = Convert.ToUInt16(xmReadWeaponStats.GetAttribute("Quantity"));
                    bw.Write(qty_Lvl4);
                }
                if (xmReadWeaponStats.NodeType == XmlNodeType.Element && xmReadWeaponStats.Name == "Lvl-5")
                {
                    ushort qty_Lvl5 = Convert.ToUInt16(xmReadWeaponStats.GetAttribute("Quantity"));
                    bw.Write(qty_Lvl5);
                }
                if (xmReadWeaponStats.NodeType == XmlNodeType.Element && xmReadWeaponStats.Name == "Lvl-6")
                {
                    ushort qty_Lvl6 = Convert.ToUInt16(xmReadWeaponStats.GetAttribute("Quantity"));
                    bw.Write(qty_Lvl6);
                }
                if (xmReadWeaponStats.NodeType == XmlNodeType.Element && xmReadWeaponStats.Name == "Lvl-7")
                {
                    ushort qty_Lvl7 = Convert.ToUInt16(xmReadWeaponStats.GetAttribute("Quantity"));
                    bw.Write(qty_Lvl7);
                }
            }
        }


        public void WeaponAvailUpgrade()
        {
            bw.BaseStream.Position = (int)Enums.UsefulLocations.WeapAvailableUp;

            while (xmReadWeaponAvail.Read())
            {
                if (xmReadWeaponAvail.NodeType == XmlNodeType.Element && xmReadWeaponAvail.Name == "Weapon")
                {
                    ushort weaponID = Convert.ToUInt16(xmReadWeaponAvail.GetAttribute("ID"));
                    bw.Write(weaponID);
                }
                if (xmReadWeaponAvail.NodeType == XmlNodeType.Element && xmReadWeaponAvail.Name == "FirePower")
                {
                    byte firePower = Convert.ToByte(xmReadWeaponAvail.GetAttribute("Avail-Lvl"));
                    bw.Write(firePower);
                }
                if (xmReadWeaponAvail.NodeType == XmlNodeType.Element && xmReadWeaponAvail.Name == "FiringRate")
                {
                    byte firingRate = Convert.ToByte(xmReadWeaponAvail.GetAttribute("Avail-Lvl"));
                    bw.Write(firingRate);
                }
                if (xmReadWeaponAvail.NodeType == XmlNodeType.Element && xmReadWeaponAvail.Name == "ReloadSpeed")
                {
                    byte reloadSpeed = Convert.ToByte(xmReadWeaponAvail.GetAttribute("Avail-Lvl"));
                    bw.Write(reloadSpeed);
                }
                if (xmReadWeaponAvail.NodeType == XmlNodeType.Element && xmReadWeaponAvail.Name == "Capacity")
                {
                    byte capacity = Convert.ToByte(xmReadWeaponAvail.GetAttribute("Avail-Lvl"));
                    bw.Write(capacity);
                    bw.Seek(2, SeekOrigin.Current);
                }
            }
        }

        public void WeaponMaxLvl()
        {
            bw.BaseStream.Position = (int)Enums.UsefulLocations.WeapMaxLvl;

            while (xmReadWeaponMaxLvl.Read())
            {
                if (xmReadWeaponMaxLvl.NodeType == XmlNodeType.Element && xmReadWeaponMaxLvl.Name == "Weapon")
                {
                    ushort weaponID = Convert.ToUInt16(xmReadWeaponMaxLvl.GetAttribute("ID"));
                    bw.Write(weaponID);
                }
                if (xmReadWeaponMaxLvl.NodeType == XmlNodeType.Element && xmReadWeaponMaxLvl.Name == "FirePower")
                {
                    byte firePowerMaxLvl = Convert.ToByte(xmReadWeaponMaxLvl.GetAttribute("Max-Lvl"));
                    bw.Write(firePowerMaxLvl);
                }
                if (xmReadWeaponMaxLvl.NodeType == XmlNodeType.Element && xmReadWeaponMaxLvl.Name == "FiringRate")
                {
                    byte firingRateMaxLvl = Convert.ToByte(xmReadWeaponMaxLvl.GetAttribute("Max-Lvl"));
                    bw.Write(firingRateMaxLvl);
                }
                if (xmReadWeaponMaxLvl.NodeType == XmlNodeType.Element && xmReadWeaponMaxLvl.Name == "ReloadSpeed")
                {
                    byte reloadSpeedMaxLvl = Convert.ToByte(xmReadWeaponMaxLvl.GetAttribute("Max-Lvl"));
                    bw.Write(reloadSpeedMaxLvl);
                }
                if (xmReadWeaponMaxLvl.NodeType == XmlNodeType.Element && xmReadWeaponMaxLvl.Name == "Capacity")
                {
                    byte capacityMaxLvl = Convert.ToByte(xmReadWeaponMaxLvl.GetAttribute("Max-Lvl"));
                    bw.Write(capacityMaxLvl);
                }
            }
        }

        public void WeaponPower()
        {
            bw.BaseStream.Position = (int)Enums.UsefulLocations.WeapFirePower;

            while (xmReadWeaponPower.Read())
            {
                if (xmReadWeaponPower.NodeType == XmlNodeType.Element && xmReadWeaponPower.Name == "FirePower")
                {
                    while (xmReadWeaponPower.Read())
                    {
                        if (xmReadWeaponPower.NodeType == XmlNodeType.Element && xmReadWeaponPower.Name == "Lvl-1")
                        {
                            float firePower_lvl1 = Convert.ToSingle(xmReadWeaponPower.GetAttribute("Value"));
                            if (firePower_lvl1 > FixedFirePower)
                            {
                                bw.Write((float)FixedFirePower);
                            }
                            else
                            {
                                bw.Write((float)firePower_lvl1);
                            }
                        }
                        if (xmReadWeaponPower.NodeType == XmlNodeType.Element && xmReadWeaponPower.Name == "Lvl-2")
                        {
                            float firePower_lvl2 = Convert.ToSingle(xmReadWeaponPower.GetAttribute("Value"));
                            if (firePower_lvl2 > FixedFirePower)
                            {
                                bw.Write((float)FixedFirePower);
                            }
                            else
                            {
                                bw.Write((float)firePower_lvl2);
                            }
                        }
                        if (xmReadWeaponPower.NodeType == XmlNodeType.Element && xmReadWeaponPower.Name == "Lvl-3")
                        {
                            float firePower_lvl3 = Convert.ToSingle(xmReadWeaponPower.GetAttribute("Value"));
                            if (firePower_lvl3 > FixedFirePower)
                            {
                                bw.Write((float)FixedFirePower);
                            }
                            else
                            {
                                bw.Write((float)firePower_lvl3);
                            }
                        }
                        if (xmReadWeaponPower.NodeType == XmlNodeType.Element && xmReadWeaponPower.Name == "Lvl-4")
                        {
                            float firePower_lvl4 = Convert.ToSingle(xmReadWeaponPower.GetAttribute("Value"));
                            if (firePower_lvl4 > FixedFirePower)
                            {
                                bw.Write((float)FixedFirePower);
                            }
                            else
                            {
                                bw.Write((float)firePower_lvl4);
                            }
                        }
                        if (xmReadWeaponPower.NodeType == XmlNodeType.Element && xmReadWeaponPower.Name == "Lvl-5")
                        {
                            float firePower_lvl5 = Convert.ToSingle(xmReadWeaponPower.GetAttribute("Value"));
                            if (firePower_lvl5 > FixedFirePower)
                            {
                                bw.Write((float)FixedFirePower);
                            }
                            else
                            {
                                bw.Write((float)firePower_lvl5);
                            }
                        }
                        if (xmReadWeaponPower.NodeType == XmlNodeType.Element && xmReadWeaponPower.Name == "Lvl-6")
                        {
                            float firePower_lvl6 = Convert.ToSingle(xmReadWeaponPower.GetAttribute("Value"));
                            if (firePower_lvl6 > FixedFirePower)
                            {
                                bw.Write((float)FixedFirePower);
                            }
                            else
                            {
                                bw.Write((float)firePower_lvl6);
                            }
                        } 
                        if (xmReadWeaponPower.NodeType == XmlNodeType.Element && xmReadWeaponPower.Name == "Lvl-7")
                        {
                            float firePower_lvl7 = Convert.ToSingle(xmReadWeaponPower.GetAttribute("Value"));
                            if (firePower_lvl7 > FixedFirePower)
                            {
                                bw.Write((float)FixedFirePower);
                            }
                            else
                            {
                                bw.Write((float)firePower_lvl7);
                            }
                            break;
                        } 
                    }
                }
            }
        }

        public void WeaponUpgradePrice()
        {
            bw.BaseStream.Position = (int)Enums.UsefulLocations.WeapUpgradePrice;

            while (xmReadWeaponUpgradePrice.Read())
            {
                if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Weapon")
                {
                    ushort weaponPriceID = Convert.ToUInt16(xmReadWeaponUpgradePrice.GetAttribute("ID"));
                    bw.Write(weaponPriceID);
                }
                if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "FirePower")
                {
                    while (xmReadWeaponUpgradePrice.Read())
                    {
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-1")
                        {
                            int firePowerPrice_Lvl1 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (firePowerPrice_Lvl1 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(firePowerPrice_Lvl1 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-2")
                        {
                            int firePowerPrice_Lvl2 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (firePowerPrice_Lvl2 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(firePowerPrice_Lvl2 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-3")
                        {
                            int firePowerPrice_Lvl3 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (firePowerPrice_Lvl3 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(firePowerPrice_Lvl3 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-4")
                        {
                            int firePowerPrice_Lvl4 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (firePowerPrice_Lvl4 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(firePowerPrice_Lvl4 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-5")
                        {
                            int firePowerPrice_Lvl5 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (firePowerPrice_Lvl5 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(firePowerPrice_Lvl5 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-6")
                        {
                            int firePowerPrice_Lvl6 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (firePowerPrice_Lvl6 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(firePowerPrice_Lvl6 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-7")
                        {
                            int firePowerPrice_Lvl7 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (firePowerPrice_Lvl7 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(firePowerPrice_Lvl7 / 10));
                            }
                            break;
                        }
                    }
                }
                if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "FiringRate")
                {
                    while (xmReadWeaponUpgradePrice.Read())
                    {
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-1")
                        {
                            int firingRatePrice_Lvl1 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (firingRatePrice_Lvl1 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(firingRatePrice_Lvl1 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-2")
                        {
                            int firingRatePrice_Lvl2 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (firingRatePrice_Lvl2 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(firingRatePrice_Lvl2 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-3")
                        {
                            int firingRatePrice_Lvl3 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (firingRatePrice_Lvl3 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(firingRatePrice_Lvl3 / 10));
                            }
                            break;
                        }
                    }
                }
                if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "ReloadSpeed")
                {
                    while (xmReadWeaponUpgradePrice.Read())
                    {
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-1")
                        {
                            int reloadSpeed_Lvl1 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (reloadSpeed_Lvl1 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(reloadSpeed_Lvl1 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-2")
                        {
                            int reloadSpeed_Lvl2 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (reloadSpeed_Lvl2 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(reloadSpeed_Lvl2 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-3")
                        {
                            int reloadSpeed_Lvl3 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (reloadSpeed_Lvl3 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(reloadSpeed_Lvl3 / 10));
                            }
                            break;
                        }
                    }
                }
                if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Capacity")
                {
                    while (xmReadWeaponUpgradePrice.Read())
                    {
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-1")
                        {
                            int capacityPrice_Lvl1 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (capacityPrice_Lvl1 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(capacityPrice_Lvl1 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-2")
                        {
                            int capacityPrice_Lvl2 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (capacityPrice_Lvl2 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(capacityPrice_Lvl2 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-3")
                        {
                            int capacityPrice_Lvl3 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (capacityPrice_Lvl3 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(capacityPrice_Lvl3 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-4")
                        {
                            int capacityPrice_Lvl4 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (capacityPrice_Lvl4 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(capacityPrice_Lvl4 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-5")
                        {
                            int capacityPrice_Lvl5 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (capacityPrice_Lvl5 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(capacityPrice_Lvl5 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-6")
                        {
                            int capacityPrice_Lvl6 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (capacityPrice_Lvl6 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(capacityPrice_Lvl6 / 10));
                            }
                        }
                        if (xmReadWeaponUpgradePrice.NodeType == XmlNodeType.Element && xmReadWeaponUpgradePrice.Name == "Lvl-7")
                        {
                            int capacityPrice_Lvl7 = Convert.ToInt32(xmReadWeaponUpgradePrice.GetAttribute("Price"));

                            if (capacityPrice_Lvl7 > fixedPriceValue)
                            {
                                bw.Write((ushort)(fixedPriceValue / 10));
                            }
                            else
                            {
                                bw.Write((ushort)(capacityPrice_Lvl7 / 10));
                            }
                            break;
                        }
                    }
                }
            }
            fs.Flush();
            fs.Close();
            xmReadWeaponUpgradePrice.Close();
            bw.Close();
        }
    }
}
