using System;

namespace CSCourseLab3.Forms
{
    public class FifthForm : Shapes
    {
        public override void generateElementsOfArrayByRandomNumbers()
        {
            Random random = new Random();
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < _arrayForShape.GetLength(1); j++)
                {
                    if (j < _arrayForShape.GetLength(1) - i && j >= i)
                    {
                        _arrayForShape[i, j] = Char.Parse(random.Next(Config.MinRandomElement, Config.MaxRandomElement).ToString());
                    }
                    else if (j <= i && j >= _arrayForShape.GetLength(1) - i - 1 )
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
                    if (j < _arrayForShape.GetLength(1) - i && j >= i)
                    {
                        _arrayForShape[i, j] = Char.Parse(random.Next(startNumber, finishNumber).ToString());
                    }
                    else if (j <= i && j >= _arrayForShape.GetLength(1) - i - 1 )
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
                    if (j < _arrayForShape.GetLength(1) - i && j >= i)
                    {
                        _arrayForShape[i, j] = (char)random.Next(Config.StartingUnicodeForSymbols, Config.FinishingUnicodeForSymbols);
                    }
                    else if (j <= i && j >= _arrayForShape.GetLength(1) - i - 1 )
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
                    if (j < _arrayForShape.GetLength(1) - i && j >= i)
                    {
                        _arrayForShape[i, j] = (char)random.Next(Config.StartingUnicodeForEnglishAlphabet, Config.FinishingUnicodeForEnglishAlphabet);
                    }
                    else if (j <= i && j >= _arrayForShape.GetLength(1) - i - 1 )
                    {
                        _arrayForShape[i, j] = (char)random.Next(Config.StartingUnicodeForEnglishAlphabet, Config.StartingUnicodeForEnglishAlphabet);
                    }
                    else
                    {
                        _arrayForShape[i, j] = '0';
                    }
                }
            }
        }

        public override int findMaxElementInTheAreaOfMatrix(Shapes shape)
        {
            throw new NotImplementedException();
        }

        public override int findMinElementInTheAreaOfMatrix(Shapes shape)
        {
            throw new NotImplementedException();
        }

        public override int findSymbolInTheAreaOfMatrix(Shapes shape, char symbolToFind)
        {
            throw new NotImplementedException();
        }
    }
}