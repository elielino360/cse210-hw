namespace GoalTracker
{
    public class ChecklistGoal : Goal
    {
        private int _amountComplete = 0;
        private int _target = 0;
        private int _Bonus = 0;

        public ChecklistGoal() : base()
        {
            Console.WriteLine("Enter how many times must the checklist goal be completed for a bonus? ");
            _amountComplete = Program.SafeParse();
            Console.WriteLine($"Bonus point to be reward once it is completed {_amountComplete} times? ");
            _Bonus = Program.SafeParse();
        }

        public ChecklistGoal(StreamReader read) : base(read)
        {
            _amountComplete = int.Parse(read.ReadLine());
            _target = int.Parse(read.ReadLine());
            _Bonus = int.Parse(read.ReadLine());
        }        

        public override void Complete()
        {
            if (!_isCompleted)
            {
                _target++;
                _points += _pointsForEachCompletion;

                if (_target == _amountComplete)
                {
                    _isCompleted = true;
                    _points += _Bonus;
                }
            }
        }

        protected override string GetDescription()
        {
            return "each time you accomplish this goal";
        }

        protected override string GoalTypeName()
        {
            return "checklist goal";
        }

        public override string DisplayString() 
        {
            return $"{base.DisplayString()} {GetProgressStatus()}";  
        }

        private string GetProgressStatus()
        {
            return $"Completed {_target}/{_amountComplete} times.";
        }

        public override void WriteToStreamWriter(StreamWriter mywriter)
        {
            base.WriteToStreamWriter(mywriter);
            mywriter.WriteLine(_amountComplete);
            mywriter.WriteLine(_target);
            mywriter.WriteLine(_Bonus);
        }   
    }
}