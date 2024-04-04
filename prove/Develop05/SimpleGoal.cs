namespace GoalTracker 
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal() : base()
        {
        }

        public SimpleGoal(StreamReader read) : base(read)
        {
        }

        public override void Complete()
        {
            if (!_isCompleted)
            {
                _isCompleted = true;
                _points += _pointsForEachCompletion;
            }
        }

        protected override string GetDescription()
        {
            return "completion";
        }

        protected override string GoalTypeName()
        {
            return "Simple Goal";
        }            
    }
}