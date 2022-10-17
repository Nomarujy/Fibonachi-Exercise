namespace Fibonachi.Perfomace.SequenceFinder
{
    public interface ISequenceFinder
    {
        int FindBySameList(List<int> nums);
        void ResetSequence();
    }
}