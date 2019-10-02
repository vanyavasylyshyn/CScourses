using System;

namespace CSCourseLab3
{
    public abstract class  Shapes
    {
        protected char[,] _arrayForShape = new char[5,5];
        public abstract void generateElementsOfArrayByRandomNumbers();
        public abstract void generateElementsOfArrayByRange(int startNumber, int finishNumber);
        public abstract void generateElementsOfArrayByAnySymbols();
        public abstract void generateElementsOfArrayByEnglishAlphabetSymbols();
        
        public abstract int findMaxElementInTheAreaOfMatrix(Shapes shape);
        public abstract int findMinElementInTheAreaOfMatrix(Shapes shape);
        public abstract int findSymbolInTheAreaOfMatrix(Shapes shape, char symbolToFind);

        public char getElementFromArray(int indexRow, int indexColumn)
        {
            return _arrayForShape[indexRow, indexColumn];
        }
        public void setElementInArray(char element, int indexRow, int indexColumn)
        {
            _arrayForShape[indexRow, indexColumn] = element;
        }
        public void transposeArray()
        {
            int arrayLangth = _arrayForShape.GetLength(0);
            
            for (int layer = 0; layer < arrayLangth / 2; layer++)
            {
                int firsLayerOfArray = layer;
                int lastLayerOfArray = arrayLangth - 1 - layer;

                for (int i = firsLayerOfArray; i < lastLayerOfArray; i++)
                {
                    int offsetOfArray = i - firsLayerOfArray;

                    char top = _arrayForShape[firsLayerOfArray, i];

                    _arrayForShape[firsLayerOfArray, i] =
                        _arrayForShape[lastLayerOfArray - offsetOfArray, firsLayerOfArray];
                    _arrayForShape[lastLayerOfArray - offsetOfArray, firsLayerOfArray] =
                        _arrayForShape[lastLayerOfArray, lastLayerOfArray - offsetOfArray];
                    _arrayForShape[lastLayerOfArray, lastLayerOfArray - offsetOfArray] =
                        _arrayForShape[i, lastLayerOfArray];
                    _arrayForShape[i, lastLayerOfArray] = top;

                }
            }

        }

        public void showArray()
        {
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < _arrayForShape.GetLength(1); j++)
                {
                    Console.Write(_arrayForShape[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        /*rotate 180
            int buffer;
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    buffer = _arrayForShape[i, j];
                    _arrayForShape[i, j] = _arrayForShape[j, i];
                    _arrayForShape[j, i] = buffer;
                }
            }
            */
        
        /*form 7
         * Random random = new Random();
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < _arrayForShape.GetLength(1) - i; j++)
                {
                    if (j <= i)
                    {
                        _arrayForShape[i, j] = Char.Parse(random.Next(10).ToString());
                    }
                    else
                    {
                        _arrayForShape[i, j] = '0';
                    }
                }
            }
         */
        
        /*form 10
         * Random random = new Random();
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < _arrayForShape.GetLength(1); j++)
                {
                    if (j < _arrayForShape.GetLength(1) - i && j >= i)
                    {
                        _arrayForShape[i, j] = Char.Parse(random.Next(10).ToString());
                    }
                    else
                    {
                        _arrayForShape[i, j] = '0';
                    }
                }
            }
         */
        
        //TODO переписати елементи з одної області в іншу
    }
}