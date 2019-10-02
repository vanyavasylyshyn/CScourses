using System;

namespace CSCourseLab3.Forms
{
    public class FourthForm : Shapes
    {
        public override void generateElementsOfArrayByRandomNumbers()
        {
            Random random = new Random();
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < _arrayForShape.GetLength(1); j++)
                {
                    if (j+1 >= _arrayForShape.GetLength(1) - i)
                    {
                        _arrayForShape[i, j] = Char.Parse(random.Next(Config.MinRandomElement, Config.MaxRandomElement).ToString());
                        
                    }
                    else
                    {
                        _arrayForShape[i, j] = '0';
                    }
                }
            }        
        }

        public override void generateElementsOfArrayByRange(int startNumber, int finishNumber)
        {
            Random random = new Random();
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < _arrayForShape.GetLength(1); j++)
                {
                    if (j+1 >= _arrayForShape.GetLength(1) - i)
                    {
                        _arrayForShape[i, j] = Char.Parse(random.Next(startNumber, finishNumber).ToString());
                        
                    }
                    else
                    {
                        _arrayForShape[i, j] = '0';
                    }
                }
            }
            
        }

        public override void generateElementsOfArrayByAnySymbols()
        {
            Random random = new Random();
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < _arrayForShape.GetLength(1); j++)
                {
                    if (j+1 >= _arrayForShape.GetLength(1) - i)
                    {
                        _arrayForShape[i, j] = (char)random.Next(Config.StartingUnicodeForSymbols, Config.FinishingUnicodeForSymbols);
                        
                    }
                    else
                    {
                        _arrayForShape[i, j] = '0';
                    }
                }
            }
        }

        public override void generateElementsOfArrayByEnglishAlphabetSymbols()
        {
            Random random = new Random();
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < _arrayForShape.GetLength(1); j++)
                {
                    if (j+1 >= _arrayForShape.GetLength(1) - i)
                    {
                        _arrayForShape[i, j] = (char)random.Next(Config.StartingUnicodeForEnglishAlphabet, Config.FinishingUnicodeForEnglishAlphabet);
                        
                    }
                    else
                    {
                        _arrayForShape[i, j] = '0';
                    }
                }
            }
        }
    }
}