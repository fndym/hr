namespace CompareTriplets
{
    public class Score
    {
        private int clarityScore = 0;
        private int originalityScore = 0;
        private int difficultyScore = 0;

        public Score(int clarity, int originality, int difficulty)
        {
            this.clarityScore = clarity;
            this.originalityScore = originality;
            this.difficultyScore = difficulty;
        }

        public int Compare(Score other)
        {
            int result = 0;

            result += this.clarityScore > other.clarityScore ? 1 : 0;
            result += this.originalityScore > other.originalityScore ? 1 : 0;
            result += this.difficultyScore > other.difficultyScore ? 1 : 0;

            return result;
        }
    }
}