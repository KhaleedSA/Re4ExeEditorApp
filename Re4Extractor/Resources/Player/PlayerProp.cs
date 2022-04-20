namespace Re4ExeExtractor.Resources.Player
{
    public class PlayerProp
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryReader br = new(fs);

        public int Leon
        {
            get
            {
                br.BaseStream.Position = (int)Enums.PlayerHp.S_Leon;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }

        public int LeonWesker
        {
            get
            {
                br.BaseStream.Position = (int)Enums.PlayerHp.M_Leon_Wesker;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }

        public int Unkown1
        {
            get
            {
                br.BaseStream.Position = (int)Enums.PlayerHp.Unk1;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }

        public int AdaAssignment
        {
            get
            {
                br.BaseStream.Position = (int)Enums.PlayerHp.SM_Ada;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }

        public int AdaStory
        {
            get
            {
                br.BaseStream.Position = (int)Enums.PlayerHp.S_Ada;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }

        public int Unkown2
        {
            get
            {
                br.BaseStream.Position = (int)Enums.PlayerHp.Unk2;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }

        public int Hunk
        {
            get
            {
                br.BaseStream.Position = (int)Enums.PlayerHp.M_Hunk;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }

        public int Krauser
        {
            get
            {
                br.BaseStream.Position = (int)Enums.PlayerHp.M_Krauser;
                br.BaseStream.Seek(1, SeekOrigin.Current);
                return br.ReadInt32();
            }
        }
    }
}
