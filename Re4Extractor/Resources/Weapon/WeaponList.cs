﻿namespace Re4ExeExtractor.Resources.Weapon
{
    public class WeaponList
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryReader br = new(fs);
        private static readonly Helper helper = new();


        #region Weapon Stats
        public List<int> StPos = new();
        public List<short> MdLoad = new();
        public List<short> Attachment = new();
        public List<byte> AmmoType = new();

        // Weapon Capacity Quantity for each Lvl upgrade
        public List<ushort> CpQuantity_Lvl_1 = new();
        public List<ushort> CpQuantity_Lvl_2 = new();
        public List<ushort> CpQuantity_Lvl_3 = new();
        public List<ushort> CpQuantity_Lvl_4 = new();
        public List<ushort> CpQuantity_Lvl_5 = new();
        public List<ushort> CpQuantity_Lvl_6 = new();
        public List<ushort> CpQuantity_Lvl_7 = new();
        #endregion

        #region Max Lvl
        public List<int> PosMaxLvl = new();
        public List<byte> FpMaxLvl = new();
        public List<byte> FrMaxLvl = new();
        public List<byte> RsMaxLvl = new();
        public List<byte> CpMaxLvl = new();
        #endregion

        #region Fire Power
        public List<string> FpName = new();
        public List<int> FpPos = new();
        public List<float> FpLvl_2 = new();
        public List<float> FpLvl_3 = new();
        public List<float> FpLvl_4 = new();
        public List<float> FpLvl_5 = new();
        public List<float> FpLvl_6 = new();
        public List<float> FpLvl_7 = new();
        #endregion

        #region Upgrade Price
        public List<int> UpPosPrice = new();
        public List<int> UpFirePowerPrice_1 = new();
        public List<int> UpFirePowerPrice_2 = new();
        public List<int> UpFirePowerPrice_3 = new();
        public List<int> UpFirePowerPrice_4 = new();
        public List<int> UpFirePowerPrice_5 = new();
        public List<int> UpFirePowerPrice_6 = new();
        public List<int> UpFirePowerPrice_7 = new();

        public List<int> UpFiringRatePrice_1 = new();
        public List<int> UpFiringRatePrice_2 = new();
        public List<int> UpFiringRatePrice_3 = new();
        
        public List<int> UpReloadSpeedPrice_1 = new();
        public List<int> UpReloadSpeedPrice_2 = new();
        public List<int> UpReloadSpeedPrice_3 = new();

        public List<int> UpCapacityPrice_1 = new();
        public List<int> UpCapacityPrice_2 = new();
        public List<int> UpCapacityPrice_3 = new();
        public List<int> UpCapacityPrice_4 = new();
        public List<int> UpCapacityPrice_5 = new();
        public List<int> UpCapacityPrice_6 = new();
        public List<int> UpCapacityPrice_7 = new();
        #endregion

        #region Weapons Available Upgrade
        public List<int> AvailPos = new();
        public List<byte> AvailFp = new();
        public List<byte> AvailFr = new();
        public List<byte> AvailRs = new();
        public List<byte> AvailCp = new();
        #endregion


        // Read Weapon Stats and Capacity Table
        public List<ushort> GetWeaponStatsID()
        {
            int StatsTableRow = 43;
            br.BaseStream.Position = (int)Enums.UsefulLocations.WeapStats;

            List<ushort> stWeaponID = new();

            for (int i = 0; i < StatsTableRow; i++)
            {
                StPos.Add((int)br.BaseStream.Position);

                stWeaponID.Add(br.ReadUInt16());
                helper.CheckItemName(checkID:0);

                MdLoad.Add(br.ReadInt16());
                Attachment.Add(br.ReadInt16());
                AmmoType.Add(br.ReadByte());
                br.BaseStream.Seek(1, SeekOrigin.Current);
                CpQuantity_Lvl_1.Add(br.ReadUInt16());
                CpQuantity_Lvl_2.Add(br.ReadUInt16());
                CpQuantity_Lvl_3.Add(br.ReadUInt16());
                CpQuantity_Lvl_4.Add(br.ReadUInt16());
                CpQuantity_Lvl_5.Add(br.ReadUInt16());
                CpQuantity_Lvl_6.Add(br.ReadUInt16());
                CpQuantity_Lvl_7.Add(br.ReadUInt16());
            }

            return stWeaponID;
        }

        // Read Weapon MaxLvl Upgrade Table.
        public List<ushort> GetMaxLvlID()
        {
            int mlTableRow = 30;
            br.BaseStream.Position = (int)Enums.UsefulLocations.WeapMaxLvl;

            List<ushort> mlWeaponID = new();

            for (int i = 0; i < mlTableRow; i++)
            {
                PosMaxLvl.Add((int)br.BaseStream.Position);

                mlWeaponID.Add(br.ReadUInt16());
                helper.CheckItemName(checkID:0);

                FpMaxLvl.Add(br.ReadByte());
                FrMaxLvl.Add(br.ReadByte());
                RsMaxLvl.Add(br.ReadByte());
                CpMaxLvl.Add(br.ReadByte());
            }

            return mlWeaponID;
        }

        // Read Weapon FirePower Table
        public List<float> GetFpLvl_1()
        {
            int fpTableRow = 49;
            br.BaseStream.Position = (int)Enums.UsefulLocations.WeapFirePower;

            List<float> fpLvl_1 = new();

            for (int i = 0; i < fpTableRow; i++)
            {
                int firePowerPos = (int)br.BaseStream.Position;
                FpPos.Add((int)br.BaseStream.Position);

                switch (firePowerPos)
                {
                    case (int)Enums.CustomFirePowerLocation.Punisher:
                        FpName.Add("Punisher");
                        break;
                    case (int)Enums.CustomFirePowerLocation.HandGun:
                        FpName.Add("HandGun");
                        break;
                    case (int)Enums.CustomFirePowerLocation.Red9:
                        FpName.Add("Red9");
                        break;
                    case (int)Enums.CustomFirePowerLocation.BlackTail:
                        FpName.Add("BlackTail");
                        break;
                    case (int)Enums.CustomFirePowerLocation.Broken_Butterfly:
                        FpName.Add("Broken_Butterfly");
                        break;
                    case (int)Enums.CustomFirePowerLocation.Killer7:
                        FpName.Add("Killer7");
                        break;
                    case (int)Enums.CustomFirePowerLocation.ShotGun:
                        FpName.Add("ShotGun");
                        break;
                    case (int)Enums.CustomFirePowerLocation.Striker:
                        FpName.Add("Striker");
                        break;
                    case (int)Enums.CustomFirePowerLocation.Rifle:
                        FpName.Add("Rifle");
                        break;
                    case (int)Enums.CustomFirePowerLocation.Rifle_SemiAuto:
                        FpName.Add("Rifle_SemiAuto");
                        break;
                    case (int)Enums.CustomFirePowerLocation.TMP:
                        FpName.Add("TMP");
                        break;
                    case (int)Enums.CustomFirePowerLocation.Chicago_TypeWriter:
                        FpName.Add("Chicago_TypeWriter");
                        break;
                    case (int)Enums.CustomFirePowerLocation.HandCannon:
                        FpName.Add("HandCannon");
                        break;
                    case (int)Enums.CustomFirePowerLocation.Matilda:
                        FpName.Add("Matilda");
                        break;
                    case (int)Enums.CustomFirePowerLocation.Krauser_Bow:
                        FpName.Add("Krauser_Bow");
                        break;
                    case (int)Enums.CustomFirePowerLocation.RiotGun:
                        FpName.Add("RiotGun");
                        break;
                    case (int)Enums.CustomFirePowerLocation.BowGun:
                        FpName.Add("BowGun");
                        break;
                    default:
                        FpName.Add("Unknown");
                        break;
                }

                fpLvl_1.Add(br.ReadSingle());
                FpLvl_2.Add(br.ReadSingle());
                FpLvl_3.Add(br.ReadSingle());
                FpLvl_4.Add(br.ReadSingle());
                FpLvl_5.Add(br.ReadSingle());
                FpLvl_6.Add(br.ReadSingle());
                FpLvl_7.Add(br.ReadSingle());
            }

            return fpLvl_1;
        }

        public List<ushort> GetWeaponUpgradePrice()
        {
            int upPriceTableRow = 16;
            int fixedPirce = 32767;
            br.BaseStream.Position = (int)Enums.UsefulLocations.WeapUpgradePrice;

            List<ushort> upWeaponIDPrice = new();

            for (int i = 0; i < upPriceTableRow; i++)
            {
                UpPosPrice.Add((int)br.BaseStream.Position);

                upWeaponIDPrice.Add(br.ReadUInt16());
                helper.CheckItemName(checkID: 0);

                #region Read Fire Power Price
                int upFirePowerPrice_1 = br.ReadUInt16();
                if (upFirePowerPrice_1 >= fixedPirce)
                    UpFirePowerPrice_1.Add(fixedPirce * 10);
                else
                    UpFirePowerPrice_1.Add(upFirePowerPrice_1 * 10);

                int upFirePowerPrice_2 = br.ReadUInt16();
                if (upFirePowerPrice_2 >= fixedPirce)
                    UpFirePowerPrice_2.Add(fixedPirce * 10);
                else
                    UpFirePowerPrice_2.Add(upFirePowerPrice_2 * 10);

                int upFirePowerPrice_3 = br.ReadUInt16();
                if (upFirePowerPrice_3 >= fixedPirce)
                    UpFirePowerPrice_3.Add(fixedPirce * 10);
                else
                    UpFirePowerPrice_3.Add(upFirePowerPrice_3 * 10);

                int upFirePowerPrice_4 = br.ReadUInt16();
                if (upFirePowerPrice_4 >= fixedPirce)
                    UpFirePowerPrice_4.Add(fixedPirce * 10);
                else
                    UpFirePowerPrice_4.Add(upFirePowerPrice_4 * 10);

                int upFirePowerPrice_5 = br.ReadUInt16();
                if (upFirePowerPrice_5 >= fixedPirce)
                    UpFirePowerPrice_5.Add(fixedPirce * 10);
                else
                    UpFirePowerPrice_5.Add(upFirePowerPrice_5 * 10);

                int upFirePowerPrice_6 = br.ReadUInt16();
                if (upFirePowerPrice_6 >= fixedPirce)
                    UpFirePowerPrice_6.Add(fixedPirce * 10);
                else
                    UpFirePowerPrice_6.Add(upFirePowerPrice_6 * 10);

                int upFirePowerPrice_7 = br.ReadUInt16();
                if (upFirePowerPrice_7 >= fixedPirce)
                    UpFirePowerPrice_7.Add(fixedPirce * 10);
                else
                    UpFirePowerPrice_7.Add(upFirePowerPrice_7 * 10);
                #endregion

                #region Read Firing Rate Price
                int upFiringRatePrice_1 = br.ReadUInt16();
                if (upFiringRatePrice_1 >= fixedPirce)
                    UpFiringRatePrice_1.Add(fixedPirce * 10);
                else
                    UpFiringRatePrice_1.Add(upFiringRatePrice_1 * 10);

                int upFiringRatePrice_2 = br.ReadUInt16();
                if (upFiringRatePrice_2 >= fixedPirce)
                    UpFiringRatePrice_2.Add(fixedPirce * 10);
                else
                    UpFiringRatePrice_2.Add(upFiringRatePrice_2 * 10);

                int upFiringRatePrice_3 = br.ReadUInt16();
                if (upFiringRatePrice_3 >= fixedPirce)
                    UpFiringRatePrice_3.Add(fixedPirce * 10);
                else
                    UpFiringRatePrice_3.Add(upFiringRatePrice_3 * 10);
                #endregion

                #region Read Reload Speed Price
                int upReloadSpeedPrice_1 = br.ReadUInt16();
                if (upReloadSpeedPrice_1 >= fixedPirce)
                    UpReloadSpeedPrice_1.Add(fixedPirce * 10);
                else
                    UpReloadSpeedPrice_1.Add(upReloadSpeedPrice_1 * 10);

                int upReloadSpeedPrice_2 = br.ReadUInt16();
                if (upReloadSpeedPrice_2 >= fixedPirce)
                    UpReloadSpeedPrice_2.Add(fixedPirce * 10);
                else
                    UpReloadSpeedPrice_2.Add(upReloadSpeedPrice_2 * 10);

                int upReloadSpeedPrice_3 = br.ReadUInt16();
                if (upReloadSpeedPrice_3 >= fixedPirce)
                    UpReloadSpeedPrice_3.Add(fixedPirce * 10);
                else
                    UpReloadSpeedPrice_3.Add(upReloadSpeedPrice_3 * 10);
                #endregion

                #region Read Capacity Price
                int upCapacityPrice_1 = br.ReadUInt16();
                if (upCapacityPrice_1 >= fixedPirce)
                    UpCapacityPrice_1.Add(fixedPirce * 10);
                else
                    UpCapacityPrice_1.Add(upCapacityPrice_1 * 10);

                int upCapacityPrice_2 = br.ReadUInt16();
                if (upCapacityPrice_2 >= fixedPirce)
                    UpCapacityPrice_2.Add(fixedPirce * 10);
                else
                    UpCapacityPrice_2.Add(upCapacityPrice_2 * 10);

                int upCapacityPrice_3 = br.ReadUInt16();
                if (upCapacityPrice_3 >= fixedPirce)
                    UpCapacityPrice_3.Add(fixedPirce * 10);
                else
                    UpCapacityPrice_3.Add(upCapacityPrice_3 * 10);

                int upCapacityPrice_4 = br.ReadUInt16();
                if (upCapacityPrice_4 >= fixedPirce)
                    UpCapacityPrice_4.Add(fixedPirce * 10);
                else
                    UpCapacityPrice_4.Add(upCapacityPrice_4 * 10);

                int upCapacityPrice_5 = br.ReadUInt16();
                if (upCapacityPrice_5 >= fixedPirce)
                    UpCapacityPrice_5.Add(fixedPirce * 10);
                else
                    UpCapacityPrice_5.Add(upCapacityPrice_5 * 10);

                int upCapacityPrice_6 = br.ReadUInt16();
                if (upCapacityPrice_6 >= fixedPirce)
                    UpCapacityPrice_6.Add(fixedPirce * 10);
                else
                    UpCapacityPrice_6.Add(upCapacityPrice_6 * 10);

                int upCapacityPrice_7 = br.ReadUInt16();
                if (upCapacityPrice_7 >= fixedPirce)
                    UpCapacityPrice_7.Add(fixedPirce * 10);
                else
                    UpCapacityPrice_7.Add(upCapacityPrice_7 * 10);
                #endregion
            }

            return upWeaponIDPrice;
        }

        public List<ushort> GetAvailableID()
        {
            int availUPTableRow = 108;
            br.BaseStream.Position = (int)Enums.UsefulLocations.WeapAvailableUp;

            List<ushort> availableWeaponID = new();

            for (int i = 0; i < availUPTableRow; i++)
            {
                AvailPos.Add((int)br.BaseStream.Position);
                availableWeaponID.Add(br.ReadUInt16());
                helper.CheckItemName(checkID: 0);
                AvailFp.Add(br.ReadByte());
                AvailFr.Add(br.ReadByte());
                AvailRs.Add(br.ReadByte());
                AvailCp.Add(br.ReadByte());
                br.BaseStream.Seek(2, SeekOrigin.Current);
            }

            return availableWeaponID;
        }
    }
}
