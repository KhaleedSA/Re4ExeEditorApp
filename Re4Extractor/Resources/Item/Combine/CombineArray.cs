namespace Re4ExeEditor.Resources.Item.Combine
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
                    Id1 = comList.GetItemCombineID1()[i],
                    Id2 = comList.GetItemCombineID2()[i],
                    Result = comList.GetItemCombineResult()[i],
                    Offset = comList.Pos[i]
                };
            }
            return coArr;
        }
    }
}
