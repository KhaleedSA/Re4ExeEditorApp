namespace Re4ExeEditor.Resources.Item.Stock
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
                    Name = Enum.GetName(typeof(Enums.ItemID), stList.GetItemStockID()[i]),
                    Id = stList.GetItemStockID()[i],
                    Offset = stList.Pos[i],
                    Amount = stList.Amount[i],
                };
            }

            return stArr;
        }
    }
}
