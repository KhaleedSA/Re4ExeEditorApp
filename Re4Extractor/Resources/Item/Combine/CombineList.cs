namespace Re4ExeEditor.Resources.Item.Combine
{
    public class CombineList
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryReader br = new(fs);
        private static readonly int itemCombineTableRow = 75;

        public List<int> Pos = new();


        public List<ushort> GetItemCombineID1()
        {
            br.BaseStream.Position = (int)Enums.UsefulLocations.ItemsToCombine;

            List<ushort> id1 = new();

            for (int i = 0; i < itemCombineTableRow; i++)
            {
                Pos.Add((int)br.BaseStream.Position);
                id1.Add(br.ReadUInt16());
                br.BaseStream.Seek(4, SeekOrigin.Current);
            }

            return id1;
        }
        
        public List<ushort> GetItemCombineID2()
        {
            br.BaseStream.Position = (int)Enums.UsefulLocations.ItemsToCombine;

            List<ushort> id2 = new();

            for (int i = 0; i < itemCombineTableRow; i++)
            {
                br.BaseStream.Seek(2, SeekOrigin.Current);
                id2.Add(br.ReadUInt16());
                br.BaseStream.Seek(2, SeekOrigin.Current);
            }

            return id2;
        }

        public List<ushort> GetItemCombineResult()
        {
            br.BaseStream.Position = (int)Enums.UsefulLocations.ItemsToCombine;

            List<ushort> result = new();

            for(int i = 0; i < itemCombineTableRow; i++)
            {
                br.BaseStream.Seek(4, SeekOrigin.Current);
                result.Add(br.ReadUInt16());
            }

            return result;
        }
    }
}
