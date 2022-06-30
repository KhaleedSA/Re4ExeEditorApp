namespace Re4ExeEditor.Resources.Item.Stack
{
    public class AmmoStackArray
    {
        private static readonly AmmoStackList stackList = new();

        public string? Name { get; set; }
        public short Stack { get; set; }
        public long Offset { get; set; }

        public static AmmoStackArray[] GetAmmoStackArray()
        {
            AmmoStackArray[] stackArray = new AmmoStackArray[19];

            stackList.GetAmmoStack();
            for (int i = 0; i < stackArray.Length; i++)
            {
                stackArray[i] = new AmmoStackArray
                {
                    Name = stackList.Name[i],
                    Stack = stackList.Stack[i],
                    Offset = stackList.Pos[i],
                };
            }

            return stackArray;
        } 
    }
}
