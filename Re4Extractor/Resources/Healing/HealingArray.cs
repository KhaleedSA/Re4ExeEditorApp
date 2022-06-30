namespace Re4ExeEditor.Resources.Healing
{
    public class HealingArray
    {
        public static readonly HealingList hpProp = new();

        public string? Name { get; set; }
        public int Value { get; set; }
        public long Offset { get; set; }


        public static HealingArray[] GetHealingArray()
        {
            HealingArray[] hArr = new HealingArray[9];

            hpProp.GetHealing();
            for (int i = 0; i < hArr.Length; i++)
            {
                hArr[i] = new HealingArray
                {
                    Name = hpProp.Name[i],
                    Value = hpProp.Value[i],
                    Offset = hpProp.Pos[i]
                };
            }
            return hArr;
        }
    }
}
