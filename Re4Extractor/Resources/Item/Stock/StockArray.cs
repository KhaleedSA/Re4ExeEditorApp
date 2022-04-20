namespace Re4ExeExtractor.Resources.Item.Stock
{
    public class StockArray
    {
        private static readonly StockList stList = new();
        public string? Name { get; set; }
        public ushort Id { get; set; }
        public int Offset { get; set; }
        public ushort Amount { get; set; }

        public static StockArray[] GetStockArray()
        {
            StockArray[] stArr = new StockArray[125];

            for (int i = 0; i < stArr.Length; i++)
            {
                stArr[i] = new StockArray
                {
                    Name = Enum.GetName(typeof(Enums.ItemId), stList.GetID()[i]),
                    Id = stList.GetID()[i],
                    Offset = stList.Pos[i],
                    Amount = stList.Amount[i],
                };
            }

            return stArr;
        }
    }
}
