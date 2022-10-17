namespace Fibonachi.Perfomace.SequenceFinder
{
    public class FastSequenceFinder : ISequenceFinder
    {
        private List<int> Sequence;

        public FastSequenceFinder()
        {
            Sequence = new List<int>()
            {
                1, 1, 2,
            };
        }

        public int FindBySameList(List<int> nums)
        {
            for (int i = Sequence.Count; i < nums.Count; i++)
            {
                if (Sequence[0] == nums[i])
                {
                    if (i + Sequence.Count > nums.Count) return -1;
                    if (SequenceFullyRepeated(nums, i))
                    {
                        return i;
                    }
                }
                Sequence.Add(nums[i]);
            }

            return -1;
        }

        public void ResetSequence()
        {
            Sequence = new List<int>()
            {
                1, 1, 2,
            };
        }

        private bool SequenceFullyRepeated(List<int> nums, int startIndex)
        {
            for (int SequenceIndex = 0; SequenceIndex < Sequence.Count; SequenceIndex++)
            {
                if (Sequence[SequenceIndex] != nums[startIndex + SequenceIndex])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
