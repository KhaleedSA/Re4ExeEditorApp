namespace Re4ExeEditor.Resources.Healing
{
    public class HealingList
    {
        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryReader br = new(fs);


        public List<string?> Name = new();
        public List<int> Value = new();
        public List<long> Pos = new();

        public void GetHealing()
        {
            var healingArray = Enum.GetValues(typeof(Enums.HealingEffects));

            foreach (var heal in healingArray)
            {
                Name.Add(Enum.GetName(typeof(Enums.HealingEffects), heal));
                Pos.Add(Convert.ToInt64(heal));
                br.BaseStream.Seek(Convert.ToInt64(heal) + 1, SeekOrigin.Begin);
                Value.Add(br.ReadInt32());
            }
        }
    }
}
