namespace Re4ExeExtractor.Resources.Item.Combine
{
    public class CombineArray
    {
        private static readonly CombineList comList = new();

        public ushort Id1 { get; set; }
        public ushort Id2 { get; set; }
        public ushort Result { get; set; }
        public int Offset { get; set; }

        public static CombineArray[] GetCombineArrays()
        {
            CombineArray[] coArr = new CombineArray[75];

            for (int i = 0; i < coArr.Length; i++)
            {
                coArr[i] = new CombineArray()
                {
                    Id1 = comList.GetID1()[i],
                    Id2 = comList.GetID2()[i],
                    Result = comList.GetResult()[i],
                    Offset = comList.Pos[i]
                };
            }
            return coArr;
        }
    }
}
