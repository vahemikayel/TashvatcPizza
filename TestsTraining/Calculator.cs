using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsTraining
{
    public class Calculator
    {
        int? _lhs;
        int? _rhs;

        public Calculator()
        {
                
        }

        public int Result { get; private set; }

        public void Input(int number)
        {
            if (_lhs == null)
                _lhs = number;
            else
                _rhs = number;
        }
    
        public void Add()
        {           
            if (_rhs == null)
                throw new OperandsNullException("Right hand");

            if (_lhs == null)
                throw new OperandsNullException("Left hand");

            Result = _rhs.Value + _lhs.Value;
        }

        public void Subtract()
        {
           
            Result = _lhs.Value - _rhs.Value;
        }

        public void Abs()
        {
           
            Result =_lhs.Value>=0?_lhs.Value: -_lhs.Value;
        }
    }

    public class OperandsNullException : Exception
    {
        public string OperandName { get; private set; }
        public OperandsNullException(string operandName)
        {
            OperandName = operandName;
        }
    }
}
