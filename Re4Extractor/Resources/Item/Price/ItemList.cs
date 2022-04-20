namespace Re4ExeExtractor.Resources.Item.Price
{
    public class ItemList
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryReader br = new(fs);
        private static readonly Helper helper = new();

        public List<int> Pos = new();
        public List<int> Price = new();
        public List<short> OTP = new();

        public List<ushort> GetID()
        {

            br.BaseStream.Position = (int)Enums.UsefulLocations.ItemsPrice_Leon;

            List<ushort> id = new();

            for (int i = 0; i < 130; i++)
            {
                int itemPos = (int)br.BaseStream.Position;
                Pos.Add(itemPos);

                ushort itemID = br.ReadUInt16();
                helper.CheckItemName(checkID:0);
                id.Add(itemID);

                int itemPrice = br.ReadInt16();
                Price.Add(itemPrice);

                short itemOTP = br.ReadInt16();
                OTP.Add(itemOTP);
            }

            return id;
        }
    }
}
