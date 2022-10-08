using System.CodeDom.Compiler;

namespace Fibonachi.Utilites
{
    public class SequenceLenghtFinder
    {
        public SequenceLenghtFinder(int minimalSequenceLenght = 3)
        {
            MinimalSequenceLenght = minimalSequenceLenght;
        }

        public int MinimalSequenceLenght { get; set; }

        public int FindByList(List<int> nums)
        {
            for (int i = MinimalSequenceLenght; i < nums.Count; i++)
            {
                if (nums[0] == nums[i])
                {
                    if (ListHaveRepeatableSequence(i, nums))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private bool ListHaveRepeatableSequence(int sequenceLenght, List<int> nums)
        {
            if (sequenceLenght * 2 > nums.Count) return false;

            List<int> sequence = nums.GetRange(0, sequenceLenght);
            bool sequenceMathes = true;

            for (int i = 0; i < sequenceLenght; i++)
            {
                if (nums[sequenceLenght + i] != sequence[i])
                {
                    sequenceMathes = false;
                    break;
                }
            }
            return sequenceMathes;
        }
    }
}
