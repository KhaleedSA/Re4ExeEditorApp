namespace Re4ExeExtractor.Data.XML.WriteXML
{
    public class WriteWeapon
    {
        private static readonly string path = Directory.GetCurrentDirectory();

        public void WeaponsStats()
        {
            XDocument StatsData = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("Max Quantity value is [999], above that the Game will be bugged.\n" +
               "You can Change The ID to Any Item can Player Equipped.\n" +
               "All values are in [Decimal type] check ReadMe.txt for item ID"),

               new XElement("Class",
                          new XAttribute("Type", "Item"),
                          new XAttribute("Target", "Weapon"),
                          new XAttribute("Count", WeaponArray.GetWeaponStats().Length),
                   from wpStArr in WeaponArray.GetWeaponStats()
                   select new XElement("wClass",
                          new XElement("Weapon",
                               new XAttribute("Name", "ToDo"),
                               new XAttribute("ID", wpStArr.WeaponStatsID),
                               new XAttribute("Offset", wpStArr.WeaponStatsPos.ToString("X2")),
                          new XElement("Stats",
                          new XElement("Model",
                               new XAttribute("Name", "ToDo"),
                               new XAttribute("ID", wpStArr.WeaponMdLoad)),
                          new XElement("Attachment",
                               new XAttribute("Name", "ToDo"),
                               new XAttribute("ID", wpStArr.WeaponAttachment)),
                          new XElement("Ammo",
                               new XAttribute("Name", "ToDo"),
                               new XAttribute("ID", wpStArr.WeaponAmmoType)),
                          new XElement("Capacity",
                          new XElement("Lvl-1",
                               new XAttribute("Quantity", wpStArr.Capacity1)),
                          new XElement("Lvl-2",
                               new XAttribute("Quantity", wpStArr.Capacity2)),
                          new XElement("Lvl-3",
                               new XAttribute("Quantity", wpStArr.Capacity3)),
                          new XElement("Lvl-4",
                               new XAttribute("Quantity", wpStArr.Capacity4)),
                          new XElement("Lvl-5",
                               new XAttribute("Quantity", wpStArr.Capacity5)),
                          new XElement("Lvl-6",
                               new XAttribute("Quantity", wpStArr.Capacity6)),
                          new XElement("Lvl-7",
                               new XAttribute("Quantity", wpStArr.Capacity7))))))));

            StatsData.Save($@"{path}\bio4\Weapons\Stats.xml");
        }
        
        public void WeaponsMaxLvl()
        {
            XDocument MaxLvlData = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("You can Change The ID to Any Item can Player Equipped."),

               new XElement("Class",
                          new XAttribute("Type", "Item"),
                          new XAttribute("Target", "Weapon"),
                          new XAttribute("Count", WeaponArray.GetWeaponMaxLvl().Length),
                   from wpMxArr in WeaponArray.GetWeaponMaxLvl()
                   select new XElement("wClass",
                          new XElement("Weapon",
                               new XAttribute("Name", "ToDo"),
                               new XAttribute("ID", wpMxArr.WeaponMaxLvlID),
                               new XAttribute("Offset", wpMxArr.WeaponMaxLvlPos.ToString("X2")),
                          new XElement("Lvl",
                          new XElement("FirePower",
                               new XAttribute("Max-Lvl", wpMxArr.WeaponFpMaxLvl)),
                          new XElement("FiringRate",
                               new XAttribute("Max-Lvl", wpMxArr.WeaponFpMaxLvl)),
                          new XElement("ReloadSpeed",
                               new XAttribute("Max-Lvl", wpMxArr.WeaponRsMaxLvl)),
                          new XElement("Capacity",
                               new XAttribute("Max-Lvl", wpMxArr.WeaponCpMaxLvl)))))));

            MaxLvlData.Save($@"{path}\bio4\Weapons\MaxLvl.xml");
        }

        public void WeaponsPower()
        {
            XDocument FirePowerData = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("Max Fire Power value is [99.9], above that it will set to [99.9].\n" +
               "All Values are on [float value]."),

               new XElement("Class",
                          new XAttribute("Type", "Item"),
                          new XAttribute("Target", "Weapon"),
                          new XAttribute("Count", WeaponArray.GetWeaponFirePower().Length),
                   from wpFpArr in WeaponArray.GetWeaponFirePower()
                   select new XElement("wClass",
                          new XElement("Weapon",
                               new XAttribute("Name", wpFpArr.FirePowerName),
                          new XElement("FirePower",
                          new XElement("Lvl-1",
                               new XAttribute("Value", wpFpArr.FirePower1)),
                          new XElement("Lvl-2",
                               new XAttribute("Value", wpFpArr.FirePower2)),
                          new XElement("Lvl-3",
                               new XAttribute("Value", wpFpArr.FirePower3)),
                          new XElement("Lvl-4",
                               new XAttribute("Value", wpFpArr.FirePower4)),
                          new XElement("Lvl-5",
                               new XAttribute("Value", wpFpArr.FirePower5)),
                          new XElement("Lvl-6",
                               new XAttribute("Value", wpFpArr.FirePower6)),
                          new XElement("Lvl-7",
                               new XAttribute("Value", wpFpArr.FirePower7)))))));

            FirePowerData.Save($@"{path}\bio4\Weapons\Power.xml");
        }

        public void WeaponsUpgradePrice()
        {
            XDocument upgradePriceData = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("Max Price value is [327670], above that the Game will be bugged.\n" +
               "You can Change The ID to Any Item can Player Equipped.\n" +
               "All values are in [Decimal type] check ReadMe.txt for item ID"),

               new XElement("Class",
                          new XAttribute("Type", "Item"),
                          new XAttribute("Target", "Weapon"),
                          new XAttribute("Count", WeaponArray.GetWeaponUpgradePrice().Length),
                   from wpPrArr in WeaponArray.GetWeaponUpgradePrice()
                   select new XElement("wClass",
                          new XElement("Weapon",
                               new XAttribute("Name", wpPrArr.UpNamePrice),
                               new XAttribute("ID", wpPrArr.UpIDPrice),
                               new XAttribute("Offset", wpPrArr.UpPosPrice.ToString("X2"))),
                          new XElement("Price",
                          new XElement("FirePower",
                          new XElement("Lvl-1",
                               new XAttribute("Price", $"{wpPrArr.UpFpPrice_1}")),
                          new XElement("Lvl-2",
                               new XAttribute("Price", $"{wpPrArr.UpFpPrice_2}")),
                          new XElement("Lvl-3",
                               new XAttribute("Price", $"{wpPrArr.UpFpPrice_3}")),
                          new XElement("Lvl-4",
                               new XAttribute("Price", $"{wpPrArr.UpFpPrice_4}")),
                          new XElement("Lvl-5",
                               new XAttribute("Price", $"{wpPrArr.UpFpPrice_5}")),
                          new XElement("Lvl-6",
                               new XAttribute("Price", $"{wpPrArr.UpFpPrice_6}")),
                          new XElement("Lvl-7",
                               new XAttribute("Price", $"{wpPrArr.UpFpPrice_7}"))),
                               new XElement("FiringRate",
                          new XElement("Lvl-1",
                               new XAttribute("Price", $"{wpPrArr.UpFrPrice_1}")),
                          new XElement("Lvl-2",
                               new XAttribute("Price", $"{wpPrArr.UpFrPrice_2}")),
                          new XElement("Lvl-3",
                               new XAttribute("Price", $"{wpPrArr.UpFrPrice_3}"))),
                               new XElement("ReloadSpeed",
                          new XElement("Lvl-1",
                               new XAttribute("Price", $"{wpPrArr.UpRsPrice_1}")),
                          new XElement("Lvl-2",
                               new XAttribute("Price", $"{wpPrArr.UpRsPrice_2}")),
                          new XElement("Lvl-3",
                               new XAttribute("Price", $"{wpPrArr.UpRsPrice_3}"))),
                          new XElement("Capacity",
                          new XElement("Lvl-1",
                               new XAttribute("Price", $"{wpPrArr.UpCpPrice_1}")),
                          new XElement("Lvl-2",
                               new XAttribute("Price", $"{wpPrArr.UpCpPrice_2}")),
                          new XElement("Lvl-3",
                               new XAttribute("Price", $"{wpPrArr.UpCpPrice_3}")),
                          new XElement("Lvl-4",
                               new XAttribute("Price", $"{wpPrArr.UpCpPrice_4}")),
                          new XElement("Lvl-5",
                               new XAttribute("Price", $"{wpPrArr.UpCpPrice_5}")),
                          new XElement("Lvl-6",
                               new XAttribute("Price", $"{wpPrArr.UpCpPrice_6}")),
                          new XElement("Lvl-7",
                               new XAttribute("Price", $"{wpPrArr.UpCpPrice_7}")))))));

            upgradePriceData.Save($@"{path}\bio4\Weapons\UpgradePrice.xml");
        }

        public void WeaponsAvailableUpgrade()
        {
            XDocument AvailUpData = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),

               new XComment("You can Change The ID to Any Item can Player Equipped.\n" +
               "Between each [DummyID] is a new Merchant.\n" +
               "If you changed [DummyID] the Merchant will show the next Available Upgrade.\n"),

               new XElement("Class",
                          new XAttribute("Type", "Item"),
                          new XAttribute("Target", "Weapon"),
                          new XAttribute("Count", WeaponArray.GetWeaponAvailableUpgrade().Length),
                   from wpAvailArr in WeaponArray.GetWeaponAvailableUpgrade()
                   select new XElement("wClass",
                          new XElement("Weapon",
                               new XAttribute("Name", wpAvailArr.AvailName),
                               new XAttribute("ID", wpAvailArr.AvailId),
                               new XAttribute("Offset", wpAvailArr.AvailPos.ToString("X2")),
                          new XElement("Available-Upgrade",
                          new XElement("FirePower",
                               new XAttribute("Avail-Lvl", wpAvailArr.AvailFirePower)),
                          new XElement("FiringRate",
                               new XAttribute("Avail-Lvl", wpAvailArr.AvailFiringRate)),
                          new XElement("ReloadSpeed",
                               new XAttribute("Avail-Lvl", wpAvailArr.AvailReloadSpeed)),
                          new XElement("Capacity",
                               new XAttribute("Avail-Lvl", wpAvailArr.AvailCapacity)))))));

            AvailUpData.Save($@"{path}\bio4\Weapons\AvailableUpgrade.xml");
        }
    }
}
