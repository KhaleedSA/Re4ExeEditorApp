namespace Re4ExeExtractor.Resources.Player
{
    public class PlayerArray
    {
        private static readonly PlayerProp pProp = new();

        public string? Name { get; set; }
        public int Offset { get; set; }
        public int Value { get; set; }
        public string? Type { get; set; }


        public static PlayerArray[] GetPlayerArray()
        {

            PlayerArray[] pArr = new PlayerArray[8];

            pArr[0] = new PlayerArray
            {
                Name = $"{Enums.PlayerHp.S_Leon:G}",
                Offset = (int)Enums.PlayerHp.S_Leon,
                Value = pProp.Leon,
            };

            pArr[1] = new PlayerArray
            {
                Name = $"{Enums.PlayerHp.M_Leon_Wesker:G}",
                Offset = (int)Enums.PlayerHp.M_Leon_Wesker,
                Value = pProp.LeonWesker,
            };

            pArr[2] = new PlayerArray
            {
                Name = $"{Enums.PlayerHp.Unk1:G}",
                Offset = (int)Enums.PlayerHp.Unk1,
                Value = pProp.Unkown1,
            };

            pArr[3] = new PlayerArray
            {
                Name = $"{Enums.PlayerHp.SM_Ada:G}",
                Offset = (int)Enums.PlayerHp.SM_Ada,
                Value = pProp.AdaAssignment,
            };

            pArr[4] = new PlayerArray
            {
                Name = $"{Enums.PlayerHp.S_Ada:G}",
                Offset = (int)Enums.PlayerHp.S_Ada,
                Value = pProp.AdaStory,
            };

            pArr[5] = new PlayerArray
            {
                Name = $"{Enums.PlayerHp.Unk2:G}",
                Offset = (int)Enums.PlayerHp.Unk2,
                Value = pProp.Unkown2,
            };

            pArr[6] = new PlayerArray
            {
                Name = $"{Enums.PlayerHp.M_Hunk:G}",
                Offset = (int)Enums.PlayerHp.M_Hunk,
                Value = pProp.Hunk,
            };

            pArr[7] = new PlayerArray
            {
                Name = $"{Enums.PlayerHp.M_Krauser:G}",
                Offset = (int)Enums.PlayerHp.M_Krauser,
                Value = pProp.Krauser,
            };

            return pArr;
        }
    }
}
