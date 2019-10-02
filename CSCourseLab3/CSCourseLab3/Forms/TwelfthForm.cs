using System;

namespace CSCourseLab3.Forms
{
    public class TwelfthForm : Shapes
    {
        public override void generateElementsOfArrayByRandomNumbers()
        {
            Random random = new Random();
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < _arrayForShape.GetLength(1); j++)
                {
                    if (j < _arrayForShape.GetLength(1) && j >= i ||
                        j <= i && j > _arrayForShape.GetLength(1) - i - 2 )
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
                    if (j < _arrayForShape.GetLength(1) && j >= i ||
                        j <= i && j > _arrayForShape.GetLength(1) - i - 2 )
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
                    if (j < _arrayForShape.GetLength(1) && j >= i ||
                        j <= i && j > _arrayForShape.GetLength(1) - i - 2 )
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
                    if (j < _arrayForShape.GetLength(1) && j >= i ||
                        j <= i && j > _arrayForShape.GetLength(1) - i - 2 )
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