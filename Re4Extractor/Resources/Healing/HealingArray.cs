namespace Re4ExeExtractor.Resources.Healing
{
    public class HealingArray
    {
        public static readonly HealingProp hpProp = new();

        public string? Name { get; set; }
        public int Offset { get; set; }
        public int Value { get; set; }


        public static HealingArray[] GetHealingArray()
        {
            HealingArray[] hArr = new HealingArray[9];

            hArr[0] = new HealingArray
            {
                Name = $"{Enums.HealingEffects.MixedHerb:G}",
                Offset = (int)Enums.HealingEffects.MixedHerb,
                Value = hpProp.MixedHerb
            };
            
            hArr[1] = new HealingArray
            {
                Name = $"{Enums.HealingEffects.Unk0:G}",
                Offset = (int)Enums.HealingEffects.Unk0,
                Value = hpProp.Unknown
            };
            
            hArr[2] = new HealingArray
            {
                Name = $"{Enums.HealingEffects.WhiteEgg:G}",
                Offset = (int)Enums.HealingEffects.WhiteEgg,
                Value = hpProp.WhiteEgg
            };
            
            hArr[3] = new HealingArray
            {
                Name = $"{Enums.HealingEffects.BrownEgg:G}",
                Offset = (int)Enums.HealingEffects.BrownEgg,
                Value = hpProp.BrownEgg
            };
            
            hArr[4] = new HealingArray
            {
                Name = $"{Enums.HealingEffects.GoldenEgg_G3_FishL:G}",
                Offset = (int)Enums.HealingEffects.GoldenEgg_G3_FishL,
                Value = hpProp.GoldenEgg_G3_FishL
            };
            
            hArr[5] = new HealingArray
            {
                Name = $"{Enums.HealingEffects.FirstAid_GR:G}",
                Offset = (int)Enums.HealingEffects.FirstAid_GR,
                Value = hpProp.FirstAid_GR
            };
            
            hArr[6] = new HealingArray
            {
                Name = $"{Enums.HealingEffects.FishS:G}",
                Offset = (int)Enums.HealingEffects.FishS,
                Value = hpProp.FishS
            };
            
            hArr[7] = new HealingArray
            {
                Name = $"{Enums.HealingEffects.Green:G}",
                Offset = (int)Enums.HealingEffects.Green,
                Value = hpProp.Green
            };
            
            hArr[8] = new HealingArray
            {
                Name = $"{Enums.HealingEffects.Green2:G}",
                Offset = (int)Enums.HealingEffects.Green2,
                Value = hpProp.Green2
            };

            return hArr;
        }
    }
}
