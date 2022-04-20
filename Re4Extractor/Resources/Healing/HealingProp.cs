namespace Re4ExeExtractor.Resources.Healing
{
    public class HealingProp
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryReader br = new(fs);

        public int MixedHerb
        {
            get
            {
                br.BaseStream.Position = (int)Enums.HealingEffects.MixedHerb;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }
        public int Unknown
        {
            get
            {
                br.BaseStream.Position = (int)Enums.HealingEffects.Unk0;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }
        public int WhiteEgg
        {
            get
            {
                br.BaseStream.Position = (int)Enums.HealingEffects.WhiteEgg;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }
        public int BrownEgg
        {
            get
            {
                br.BaseStream.Position = (int)Enums.HealingEffects.BrownEgg;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }
        public int GoldenEgg_G3_FishL
        {
            get
            {
                br.BaseStream.Position = (int)Enums.HealingEffects.GoldenEgg_G3_FishL;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }
        public int FirstAid_GR
        {
            get
            {
                br.BaseStream.Position = (int)Enums.HealingEffects.FirstAid_GR;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }
        public int FishS
        {
            get
            {
                br.BaseStream.Position = (int)Enums.HealingEffects.FishS;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }
        public int Green
        {
            get
            {
                br.BaseStream.Position = (int)Enums.HealingEffects.Green;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }
        public int Green2
        {
            get
            {
                br.BaseStream.Position = (int)Enums.HealingEffects.Green2;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }
    }
}
