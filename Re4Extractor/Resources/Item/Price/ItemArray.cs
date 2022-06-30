namespace Re4ExeEditor.Resources.Item.Price
{
    public class ItemArray
    {
        private static readonly ItemList itList = new();
        public string? Name { get; set; }
        public ushort Id { get; set; }
        public int Offset { get; set; }
        public int Price { get; set; }
        public short OTP { get; set; } // one-time purchase

        public static ItemArray[] GetItemLeonArray()
        {
            ItemArray[] iArr = new ItemArray[130];

            for (int i = 0; i < iArr.Length; i++)
            {
                iArr[i] = new ItemArray
                {
                    Name = Enum.GetName(typeof(Enums.ItemID), itList.GetItemPriceLeonID()[i]),
                    Id = itList.GetItemPriceLeonID()[i],
                    Offset = itList.Pos_Leon[i],
                    Price = itList.Price_Leon[i],
                    OTP = itList.OTP_Leon[i]
                };
            }

            return iArr;
        }

        public static ItemArray[] GetItemAdaArray()
        {
            ItemArray[] iArr = new ItemArray[119];

            for (int i = 0; i < iArr.Length; i++)
            {
                iArr[i] = new ItemArray
                {
                    Name = Enum.GetName(typeof(Enums.ItemID), itList.GetItemPriceAdaID()[i]),
                    Id = itList.GetItemPriceAdaID()[i],
                    Offset = itList.Pos_Ada[i],
                    Price = itList.Price_Ada[i],
                    OTP = itList.OTP_Ada[i]
                };
            }

            return iArr;
        }
    }
}
