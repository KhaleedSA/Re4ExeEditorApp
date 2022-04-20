namespace Re4ExeExtractor.Resources.Weapon
{
    public class WeaponArray
    {
        private static readonly WeaponList wpList = new();

        #region Weapon Stats
        public string? WeaponStatsIDName { get; set; }
        public int WeaponStatsPos { get; set; }
        public ushort WeaponStatsID { get; set; }
        public short WeaponMdLoad { get; set; }
        public short WeaponAttachment { get; set; }
        public byte WeaponAmmoType { get; set; }
        public ushort Capacity1 { get; set; }
        public ushort Capacity2 { get; set; }
        public ushort Capacity3 { get; set; }
        public ushort Capacity4 { get; set; }
        public ushort Capacity5 { get; set; }
        public ushort Capacity6 { get; set; }
        public ushort Capacity7 { get; set; }
        #endregion

        #region Weapon MaxLvl
        public string? WeaponMaxLVlIDName { get; set; }
        public int WeaponMaxLvlPos { get; set; }
        public ushort WeaponMaxLvlID { get; set; }
        public byte WeaponFpMaxLvl { get; set; }
        public byte WeaponFrMaxLvl { get; set; }
        public byte WeaponRsMaxLvl { get; set; }
        public byte WeaponCpMaxLvl { get; set; }
        #endregion

        #region Fire Power
        public string? FirePowerName { get; set; }
        public int FirePowerPos { get; set; }
        public float FirePower1 { get; set; }
        public float FirePower2 { get; set; }
        public float FirePower3 { get; set; }
        public float FirePower4 { get; set; }
        public float FirePower5 { get; set; }
        public float FirePower6 { get; set; }
        public float FirePower7 { get; set; }
        #endregion

        #region Firing Rate

        public float FiringRate1{ get; set; }
        public float FiringRate2{ get; set; }
        public float FiringRate3{ get; set; }
        public float FiringRate4{ get; set; }
        public float FiringRate5{ get; set; }
        public float FiringRate6{ get; set; }
        public float FiringRate7{ get; set; }
        #endregion

        #region Reload Speed
        public float ReloadSpeed1 { get; set; }
        public float ReloadSpeed2 { get; set; }
        public float ReloadSpeed3 { get; set; }
        public float ReloadSpeed4 { get; set; }
        public float ReloadSpeed5 { get; set; }
        public float ReloadSpeed6 { get; set; }
        public float ReloadSpeed7 { get; set; }
        #endregion

        #region Upgrade Price
        public string? UpNamePrice { get; set; }
        public int UpPosPrice { get; set; }
        public ushort UpIDPrice { get; set; }

        #region Fire Power
        public int UpFpPrice_1 { get; set; }
        public int UpFpPrice_2 { get; set; }
        public int UpFpPrice_3 { get; set; }
        public int UpFpPrice_4 { get; set; }
        public int UpFpPrice_5 { get; set; }
        public int UpFpPrice_6 { get; set; }
        public int UpFpPrice_7 { get; set; }
        #endregion

        #region Firing Rate
        public int UpFrPrice_1 { get; set; }
        public int UpFrPrice_2 { get; set; }
        public int UpFrPrice_3 { get; set; }
        #endregion

        #region Reload Speed
        public int UpRsPrice_1 { get; set; }
        public int UpRsPrice_2 { get; set; }
        public int UpRsPrice_3 { get; set; }
        #endregion

        #region Capacity
        public int UpCpPrice_1 { get; set; }
        public int UpCpPrice_2 { get; set; }
        public int UpCpPrice_3 { get; set; }
        public int UpCpPrice_4 { get; set; }
        public int UpCpPrice_5 { get; set; }
        public int UpCpPrice_6 { get; set; }
        public int UpCpPrice_7 { get; set; }
        #endregion

        #endregion

        #region Available Upgrade
        public string? AvailName { get; set; }
        public ushort AvailId { get; set; }
        public int AvailPos { get; set; }
        public byte AvailFirePower { get; set; }
        public byte AvailFiringRate { get; set; }
        public byte AvailReloadSpeed { get; set; }
        public byte AvailCapacity { get; set; }
        #endregion

        public static WeaponArray[] GetWeaponStats()
        {
            WeaponArray[] wpStArr = new WeaponArray[43];

            for (int i = 0; i < wpStArr.Length; i++)
            {
                wpStArr[i] = new WeaponArray
                {
                    WeaponStatsID = wpList.GetWeaponStatsID()[i],
                    WeaponStatsPos = wpList.StPos[i],
                    WeaponMdLoad = wpList.MdLoad[i],
                    WeaponAttachment = wpList.Attachment[i],
                    WeaponAmmoType = wpList.AmmoType[i],
                    Capacity1 = wpList.CpQuantity_Lvl_1[i],
                    Capacity2 = wpList.CpQuantity_Lvl_2[i],
                    Capacity3 = wpList.CpQuantity_Lvl_3[i],
                    Capacity4 = wpList.CpQuantity_Lvl_4[i],
                    Capacity5 = wpList.CpQuantity_Lvl_5[i],
                    Capacity6 = wpList.CpQuantity_Lvl_6[i],
                    Capacity7 = wpList.CpQuantity_Lvl_7[i]
                };
            }

            return wpStArr;
        }

        public static WeaponArray[] GetWeaponMaxLvl()
        {
            WeaponArray[] weMxArr = new WeaponArray[30];

            for (int i = 0; i < weMxArr.Length; i++)
            {
                weMxArr[i] = new WeaponArray
                {
                    WeaponMaxLvlID = wpList.GetMaxLvlID()[i],
                    WeaponMaxLvlPos = wpList.PosMaxLvl[i],
                    WeaponFpMaxLvl = wpList.FpMaxLvl[i],
                    WeaponFrMaxLvl = wpList.FrMaxLvl[i],
                    WeaponRsMaxLvl = wpList.RsMaxLvl[i],
                    WeaponCpMaxLvl = wpList.CpMaxLvl[i]
                };
            }
            return weMxArr;
        }

        public static WeaponArray[] GetWeaponFirePower()
        {
            WeaponArray[] weFpArr = new WeaponArray[49];

            for (int i = 0; i < weFpArr.Length; i++)
            {
                weFpArr[i] = new WeaponArray
                {
                    FirePower1 = wpList.GetFpLvl_1()[i],
                    FirePowerName = wpList.FpName[i],
                    FirePowerPos = wpList.FpPos[i],
                    FirePower2 = wpList.FpLvl_2[i],
                    FirePower3 = wpList.FpLvl_3[i],
                    FirePower4 = wpList.FpLvl_4[i],
                    FirePower5 = wpList.FpLvl_5[i],
                    FirePower6 = wpList.FpLvl_6[i],
                    FirePower7 = wpList.FpLvl_7[i]
                };
            }
            return weFpArr;
        }

        public static WeaponArray[] GetWeaponUpgradePrice()
        {
            WeaponArray[] weUpPriceArr = new WeaponArray[16];

            for (int i = 0; i < weUpPriceArr.Length; i++)
            {
                weUpPriceArr[i] = new WeaponArray
                {
                    UpNamePrice = Enum.GetName(typeof(Enums.ItemId), wpList.GetWeaponUpgradePrice()[i]),
                    UpIDPrice = wpList.GetWeaponUpgradePrice()[i],
                    UpPosPrice = wpList.UpPosPrice[i],

                    UpFpPrice_1 = wpList.UpFirePowerPrice_1[i],
                    UpFpPrice_2 = wpList.UpFirePowerPrice_2[i],
                    UpFpPrice_3 = wpList.UpFirePowerPrice_3[i],
                    UpFpPrice_4 = wpList.UpFirePowerPrice_4[i],
                    UpFpPrice_5 = wpList.UpFirePowerPrice_5[i],
                    UpFpPrice_6 = wpList.UpFirePowerPrice_6[i],
                    UpFpPrice_7 = wpList.UpFirePowerPrice_7[i],

                    UpFrPrice_1 = wpList.UpFiringRatePrice_1[i],
                    UpFrPrice_2 = wpList.UpFiringRatePrice_2[i],
                    UpFrPrice_3 = wpList.UpFiringRatePrice_3[i],

                    UpRsPrice_1 = wpList.UpReloadSpeedPrice_1[i],
                    UpRsPrice_2 = wpList.UpReloadSpeedPrice_2[i],
                    UpRsPrice_3 = wpList.UpReloadSpeedPrice_3[i],

                    UpCpPrice_1 = wpList.UpCapacityPrice_1[i],
                    UpCpPrice_2 = wpList.UpCapacityPrice_2[i],
                    UpCpPrice_3 = wpList.UpCapacityPrice_3[i],
                    UpCpPrice_4 = wpList.UpCapacityPrice_4[i],
                    UpCpPrice_5 = wpList.UpCapacityPrice_5[i],
                    UpCpPrice_6 = wpList.UpCapacityPrice_6[i],
                    UpCpPrice_7 = wpList.UpCapacityPrice_7[i],
                };
            }
            return weUpPriceArr;
        }

        public static WeaponArray[] GetWeaponAvailableUpgrade()
        {
            WeaponArray[] weAvailArr = new WeaponArray[108];

            for (int i = 0; i < weAvailArr.Length; i++)
            {
                weAvailArr[i] = new WeaponArray
                {
                    AvailName = Enum.GetName(typeof(Enums.ItemId), wpList.GetAvailableID()[i]),
                    AvailId = wpList.GetAvailableID()[i],
                    AvailPos = wpList.AvailPos[i],
                    AvailFirePower = wpList.AvailFp[i],
                    AvailFiringRate = wpList.AvailFr[i],
                    AvailReloadSpeed = wpList.AvailRs[i],
                    AvailCapacity = wpList.AvailCp[i],
                };
            }
            return weAvailArr;
        }
    }
}
