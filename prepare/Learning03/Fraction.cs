using System;

public class Fraction
{
    

        private int _top;
        private int _bottom;

        public Fraction()
        {
            _top=1;
            _bottom=1;
        }


        public Fraction(int wholeNumber)
        {
            _top = 1;
            _bottom = wholeNumber;

        }

        public Fraction(int top, int buttom)
        {
            _top = top;
            _bottom = buttom;
        }

        public string GetFractionString()
        {
            string text= $"_top/_bottom ";
            
            return text;
        }

        public double GetDecimalValue()
        {
            return (double) _top / (double) _bottom;
        }


}