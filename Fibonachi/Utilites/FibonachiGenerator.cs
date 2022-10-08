namespace Fibonachi
{
    public class FibonachiGenerator
    {
        public int Module { get; set; }

        public int FindNumber(int x)
        {
            if (x == 0 || x == 1) return 1;

            return (FindNumber(x - 1) + FindNumber(x - 2)) % Module;
        }
    }
}
