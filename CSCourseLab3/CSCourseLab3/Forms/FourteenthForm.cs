using System;

namespace CSCourseLab3.Forms
{
    public class FourteenthForm : Shapes
    {
        public override void generateElementsOfArrayByRandomNumbers()
        {
            Random random = new Random();
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < _arrayForShape.GetLength(1); j++)
                {
                    if (j < _arrayForShape.GetLength(1) - i - 1 && j > i)
                    {
                        _arrayForShape[i, j] = '0';
                    }
                    else
                    {
                        _arrayForShape[i, j] =
                            Char.Parse(random.Next(Config.MinRandomElement, Config.MaxRandomElement).ToString());
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
                    if (j < _arrayForShape.GetLength(1) - i - 1 && j > i)
                    {
                        _arrayForShape[i, j] = '0';
                    }
                    else
                    {
                        _arrayForShape[i, j] =
                            Char.Parse(random.Next(startNumber, finishNumber).ToString());
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
                    if (j < _arrayForShape.GetLength(1) - i - 1 && j > i)
                    {
                        _arrayForShape[i, j] = '0';
                    }
                    else
                    {
                        _arrayForShape[i, j] =
                            (char)random.Next(Config.StartingUnicodeForSymbols, Config.FinishingUnicodeForSymbols);
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
                    if (j < _arrayForShape.GetLength(1) - i - 1 && j > i)
                    {
                        _arrayForShape[i, j] = '0';
                    }
                    else
                    {
                        _arrayForShape[i, j] =
                            (char)random.Next(Config.StartingUnicodeForEnglishAlphabet, Config.StartingUnicodeForEnglishAlphabet);
                    }
                }
            }
        }
    }
}