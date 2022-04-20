namespace Re4ExeExtractor.Resources.Item.Combine
{
    public class CombineList
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryReader br = new(fs);


        public List<int> Pos = new();


        public List<ushort> GetID1()
        {
            br.BaseStream.Position = (int)Enums.UsefulLocations.ItemsToCombine;

            List<ushort> id1 = new();

            for (int i = 0; i < 75; i++)
            {
                int itemPos = (int)br.BaseStream.Position;
                Pos.Add(itemPos);

                ushort itemID1 = br.ReadUInt16();
                id1.Add(itemID1);
                br.BaseStream.Seek(4, SeekOrigin.Current);
            }

            return id1;
        }
        
        public List<ushort> GetID2()
        {
            br.BaseStream.Position = (int)Enums.UsefulLocations.ItemsToCombine;

            List<ushort> id2 = new();

            for (int i = 0; i < 75; i++)
            {
                br.BaseStream.Seek(2, SeekOrigin.Current);
                ushort itemID2 = br.ReadUInt16();
                id2.Add(itemID2);
                br.BaseStream.Seek(2, SeekOrigin.Current);
            }

            return id2;
        }

        public List<ushort> GetResult()
        {
            br.BaseStream.Position = (int)Enums.UsefulLocations.ItemsToCombine;

            List<ushort> result = new();

            for(int i = 0; i < 75; i++)
            {
                br.BaseStream.Seek(4, SeekOrigin.Current);
                ushort itemResult = br.ReadUInt16();
                result.Add(itemResult);
            }

            return result;
        }
    }
}
