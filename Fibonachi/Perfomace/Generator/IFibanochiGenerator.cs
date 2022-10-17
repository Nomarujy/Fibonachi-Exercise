namespace Fibonachi.Perfomace.Generator
{
    public interface IFibanochiGenerator
    {
        List<int> Sequence { get; }
        int Module { get; set; }

        int Get(int index);
    }
}
