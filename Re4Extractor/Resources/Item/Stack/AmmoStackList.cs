namespace Re4ExeEditor.Resources.Item.Stack
{
    public class AmmoStackList
    {

        private static readonly string path = Directory.GetCurrentDirectory();
        private static readonly FileStream fs = new($@"{path}\bio4.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        private static readonly BinaryReader br = new(fs);
        private static readonly Helper helper = new();

        public List<string?> Name = new();
        public List<short> Stack = new();
        public List<long> Pos = new();
        public void GetAmmoStack()
        {
            var posArray = Enum.GetValues(typeof(Enums.AmmoStackLocation));

            foreach (var pos in posArray)
            {
                br.BaseStream.Seek(Convert.ToInt64(pos), SeekOrigin.Begin);
                Pos.Add(Convert.ToInt64(pos));
                Stack.Add(br.ReadInt16());
                Name.Add(helper.CheckAmmoStackLocation(checkID: (Enums.AmmoStackLocation)pos));
            }
        }
    }
}
