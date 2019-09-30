using System;
using System.Text.RegularExpressions;

namespace CSCourseLab3
{
    public class  Shapes
    {
        protected byte[,] _arrayForShape = new byte[10, 10];

        public virtual void generateElementsOfArrayByRandomNumbers() {}
        public virtual 
    }

    public class FirstForm : Shapes
    {
        public override void generateElementsOfArrayByRandomNumbers()
        {
            /*
            for (int i = _arrayForShape.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < _arrayForShape.GetLength(1) - j; j++)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(100);
                    _arrayForShape.SetValue(randomNumber, i, j);

                }
            }
            */
        }
    }
}