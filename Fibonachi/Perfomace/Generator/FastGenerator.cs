namespace Fibonachi.Perfomace.Generator
{
    public class FastGenerator : IFibanochiGenerator
    {
        public List<int> Sequence { get; private set; }

        public FastGenerator()
        {
            Sequence = new List<int>()
            {
                1, 1, 2
            };
        }

        private int _module;
        public int Module
        {
            get { return _module; }
            set
            {
                _module = value;
                Sequence = new() { 1, 1, 2 };
            }
        }

        public int Get(int index)
        {
            if (index >= Sequence.Count)
            {
                for (int i = Sequence.Count; i <= index; i++)
                {
                    GenerateNext();
                }
            }

            return Sequence[index];
        }

        private void GenerateNext()
        {
            int lastIndex = Sequence.Count - 1;
            var num = (Sequence[lastIndex] + Sequence[lastIndex - 1]) % Module;

            Sequence.Add(num);
        }
    }
}
