namespace Re4ExeExtractor.Data.XML.ReadXML
{
    public class ReadXml
    {
        private static readonly ReadPlayer readPlayer = new();
        private static readonly ReadItem readItem = new();
        private static readonly ReadHealing readHealing = new();
        private static readonly ReadWeapon readWeapon = new();
        public void ReadAllXml()
        {
            try
            {
                readPlayer.Player();
                readItem.ItemPrice();
                readItem.ItemCombination();
                readItem.ItemStock();
                readHealing.Healing();
                readWeapon.WeaponStats();
                readWeapon.WeaponAvailUpgrade();
                readWeapon.WeaponMaxLvl();
                readWeapon.WeaponPower();
                readWeapon.WeaponUpgradePrice();

            }
            catch (Exception ex)
            {
                Logger.WriteLog($"error: {ex.Message}");
            }
        }
    }
}
