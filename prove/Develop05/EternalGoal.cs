namespace GoalTracker 
{
    public class EternalGoal : Goal 
    {
        public EternalGoal() : base()
        {
        }

        public EternalGoal(StreamReader read) : base(read)
        {
        }

        public override void Complete()
        {
            _isCompleted = false;
            _points += _pointsForEachCompletion;
        }

        protected override string GetDescription()
        {
            return "each time this habit is repeated";
        }

        protected override string GoalTypeName()
        {
            return "eternal quest habit Goal";
        }
    }
}