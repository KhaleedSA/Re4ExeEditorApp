namespace Re4ExeEditor.Resources.Item.Price
{
    public class ItemList
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryReader br = new(fs);
        private static readonly Helper helper = new();

        #region Leon Table Price
        public List<int> Pos_Leon = new();
        public List<int> Price_Leon = new();
        public List<short> OTP_Leon = new();
        #endregion

        #region Ada Table Price
        public List<int> Pos_Ada = new();
        public List<int> Price_Ada = new();
        public List<short> OTP_Ada = new();
        #endregion

        public List<ushort> GetItemPriceLeonID()
        {
            int itemPriceTableRow = 130;
            br.BaseStream.Position = (int)Enums.UsefulLocations.ItemsPrice_Leon;

            List<ushort> id = new();

            for (int i = 0; i < itemPriceTableRow; i++)
            {
                int itemPos = (int)br.BaseStream.Position;
                Pos_Leon.Add(itemPos);

                ushort itemID = br.ReadUInt16();
                helper.CheckItemName(checkID:0);
                id.Add(itemID);

                int itemPrice = br.ReadInt16();
                Price_Leon.Add(itemPrice);

                short itemOTP = br.ReadInt16();
                OTP_Leon.Add(itemOTP);
            }

            return id;
        }

        public List<ushort> GetItemPriceAdaID()
        {
            int itemPriceTableRow = 119;

            br.BaseStream.Position = (int)Enums.UsefulLocations.ItemsPrice_Ada;

            List<ushort> id = new();

            for (int i = 0; i < itemPriceTableRow; i++)
            {
                Pos_Ada.Add((int)br.BaseStream.Position);

                ushort itemID = br.ReadUInt16();
                helper.CheckItemName(checkID:0);
                id.Add(itemID);

                Price_Ada.Add(br.ReadInt16());
                OTP_Ada.Add(br.ReadInt16());
            }

            return id;
        }
    }
}
