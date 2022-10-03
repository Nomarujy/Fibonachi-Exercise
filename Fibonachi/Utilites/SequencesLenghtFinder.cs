namespace Fibonachi.Utilites
{
    public class SequencesLenghtFinder
    {
        private const int sequenceStartLenght = 3;

        public int FindSequenceLenght(List<int> generated)
        {
            var sequence = generated.GetRange(0, sequenceStartLenght);

            for (int i = sequenceStartLenght; i < generated.Count; i++)
            {
                if (sequence[0] == generated[i])
                {
                    bool sequenceEnded = true;
                    for (int seqIndex = 1; seqIndex < sequence.Count; seqIndex++)
                    {
                        if (sequence[seqIndex] != generated[i + seqIndex])
                        {
                            sequence = generated.GetRange(0, i + seqIndex);
                            sequenceEnded = false;
                            break;
                        }
                    }
                    if (sequenceEnded)
                    {
                        return sequence.Count;
                    }
                }
                else
                {
                    sequence = generated.GetRange(0, i + 1);
                }
            }
            throw new Exception();
        }
    }
}
