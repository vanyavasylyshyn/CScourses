using System;

namespace CSCourseLab3.Forms
{
    public class ThirteenthForm : Shapes
    {
        public ThirteenthForm()
        {
            base._typeOfForm = NumberOfForms.ThirteenthForm;
        }
        public override void generateElementsOfArrayByRandomNumbers()
        {
            Random random = new Random();
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < _arrayForShape.GetLength(1); j++)
                {
                    if (j < i && j >= _arrayForShape.GetLength(1) - i )
                    {
                        _arrayForShape[i, j] = 0;
                    }
                    else
                    {
                        _arrayForShape[i, j] = random.Next(Config.MinRandomElement, Config.MaxRandomElement);
                    }
                }
            }

            _typeOfNumberArrayElements = true;
        }

        public override void generateElementsOfArrayByRange(int startNumber, int finishNumber, int typeOfNumbers)
        {
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < _arrayForShape.GetLength(1); j++)
                {
                    if (j < i && j >= _arrayForShape.GetLength(1) - i )
                    {
                        _arrayForShape[i, j] = 0;
                    }
                    else
                    {
                        if (typeOfNumbers == 1)
                        {
                            _arrayForShape[i, j] = FormsHelper.generatePairNumbersInRange(startNumber, finishNumber);
                        }
                        else
                        {
                            _arrayForShape[i, j] = FormsHelper.generateOddNumbersInRange(startNumber, finishNumber);
                        }
                    }
                }
            }

            _typeOfNumberArrayElements = true;
        }

        public override void generateElementsOfArrayByAnySymbols()
        {
            Random random = new Random();
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < _arrayForShape.GetLength(1); j++)
                {
                    if (j < i && j >= _arrayForShape.GetLength(1) - i )
                    {
                        _arrayForShape[i, j] = '0';
                    }
                    else
                    {
                        _arrayForShape[i, j] = random.Next(Config.StartingUnicodeForSymbols, Config.FinishingUnicodeForSymbols);
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
                    if (j < i && j >= _arrayForShape.GetLength(1) - i )
                    {
                        _arrayForShape[i, j] = '0';
                    }
                    else
                    {
                        _arrayForShape[i, j] = random.Next(Config.StartingUnicodeForEnglishAlphabet, Config.FinishingUnicodeForEnglishAlphabet);
                    }
                }
            }
        }
    }
}