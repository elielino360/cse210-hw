using System;
using System.Collections.Generic;

namespace GoalTracker
{
    public abstract class Goal
    {
        private string _name = "";
        private string _Description = "";
        protected bool _isCompleted = false;
        protected int _pointsForEachCompletion = 0;
        protected int _points = 0;

        public Goal()
        {
            Console.WriteLine($"What is the name of your {GoalTypeName()}? ");
            _name = Console.ReadLine();

            Console.WriteLine($"What is a short description of your {GoalTypeName()}? ");
            _Description = Console.ReadLine();

            Console.WriteLine($"Enter the points awarded for {GetDescription()}? ");
            _pointsForEachCompletion = Program.SafeParse();
        }

        public Goal(StreamReader read)
        {
            _name = read.ReadLine();
            _Description = read.ReadLine();
            _pointsForEachCompletion = int.Parse(read.ReadLine());
            _isCompleted = bool.Parse(read.ReadLine());
            _points = int.Parse(read.ReadLine());
        }

        public int GetPointsEarned()
        {
            return _points;
        }

        public string GetName()
        {
            return _name;
        }

        public bool IsComplete()
        {
            return _isCompleted;
        }

        protected string CompletedCheckbox()
        {
            return _isCompleted ? "[X]" : "[ ]";
        }

        public virtual string DisplayString()
        {
            return $"{CompletedCheckbox()} {_name} ({_Description})";
        }

        public abstract void Complete();

        protected abstract string GoalTypeName();

        protected abstract string GetDescription();

        public virtual void WriteToStreamWriter(StreamWriter MYwriter)
        {
            MYwriter.WriteLine(_name);
            MYwriter.WriteLine(_Description);
            MYwriter.WriteLine(_pointsForEachCompletion);
            MYwriter.WriteLine(_isCompleted);
            MYwriter.WriteLine(_points);
        }
    }
}