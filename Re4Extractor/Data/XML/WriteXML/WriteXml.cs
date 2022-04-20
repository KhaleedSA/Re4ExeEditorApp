namespace Re4ExeExtractor.Data.XML.WriteXML
{
    public class WriteXml
    {
        private static readonly WritePlayer writePlayer = new();
        private static readonly WriteItem writeItem = new();
        private static readonly WriteHealing writeHealing = new();
        private static readonly WriteWeapon writeWeapon = new();

        public void WriteAllXml()
        {
                

            try
            {
                writePlayer.Player();
                writeItem.ItemPrice();
                writeItem.ItemCombine();
                writeItem.ItemStock();
                writeHealing.Healing();
                writeWeapon.WeaponsStats();
                writeWeapon.WeaponsMaxLvl();
                writeWeapon.WeaponsPower();
                writeWeapon.WeaponsUpgradePrice();
                writeWeapon.WeaponsAvailableUpgrade();
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"error: {ex.Message}");
            }
        }
    }
}
