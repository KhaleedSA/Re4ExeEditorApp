namespace Re4ExeExtractor.Resources.Item.Price
{
    public class ItemArray
    {
        private static readonly ItemList itList = new();
        public string? Name { get; set; }
        public ushort Id { get; set; }
        public int Offset { get; set; }
        public int Price { get; set; }
        public short OTP { get; set; } // one-time purchase

        public static ItemArray[] GetItemArray()
        {
            ItemArray[] iArr = new ItemArray[130];

            for (int i = 0; i < iArr.Length; i++)
            {
                iArr[i] = new ItemArray
                {
                    Name = Enum.GetName(typeof(Enums.ItemId), itList.GetItemPriceID()[i]),
                    Id = itList.GetItemPriceID()[i],
                    Offset = itList.Pos[i],
                    Price = itList.Price[i],
                    OTP = itList.OTP[i]
                };
            }

            return iArr;
        }
    }
}
