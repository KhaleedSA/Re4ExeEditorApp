namespace Re4ExeExtractor.Resources.Item.Stock
{
    public class StockList
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryReader br = new(fs);
        private static readonly Helper helper = new();

        public List<int> Pos = new();
        public List<ushort> Amount = new();

        public List<ushort> GetID()
        {
            br.BaseStream.Position = (int)Enums.UsefulLocations.ItemsInStock;

            List<ushort> listID = new();

            for (int i = 0; i < 125; i++)
            {
                int pos = (int)br.BaseStream.Position;
                Pos.Add(pos);

                ushort itemID = br.ReadUInt16();
                helper.CheckItemName(checkID:0);
                listID.Add(itemID);

                ushort itemAmount = br.ReadUInt16();
                Amount.Add(itemAmount);
                br.BaseStream.Seek(4, SeekOrigin.Current);
            }
            return listID;
        }
    }
}
