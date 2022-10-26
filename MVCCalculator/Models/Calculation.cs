using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCalculator.Models
{
    public enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    public class Calculation
    {
        public double firstValue { get; set; }
        public double secondValue { get; set; }
        public double mathOp { get; set; }

        public Calculation(double firstValue, double secondValue, double mathOp)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.mathOp = mathOp;
        }

        public double performCalculation()
        {
            switch (mathOp)
            {
                case (int) Operation.Add:
                    return (firstValue + secondValue);
                case (int) Operation.Subtract:
                    return (firstValue - secondValue);
                case (int) Operation.Multiply:
                    return (firstValue * secondValue);
                default:
                    if (secondValue != 0)
                     return (firstValue / secondValue);
                    else 
                     return 0;
            }
        }
    }
}
