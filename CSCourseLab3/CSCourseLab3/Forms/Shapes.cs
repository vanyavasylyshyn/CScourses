using System;

namespace CSCourseLab3
{
    public abstract class  Shapes
    {
        protected NumberOfForms _typeOfForm;
        
        protected bool _typeOfNumberArrayElements = false;
        protected int[,] _arrayForShape = new Int32[5,5];
        
        public abstract void generateElementsOfArrayByRandomNumbers();
        public abstract void generateElementsOfArrayByRange(int startNumber, int finishNumber, int typeOfNumbers);
        public abstract void generateElementsOfArrayByAnySymbols();
        public abstract void generateElementsOfArrayByEnglishAlphabetSymbols();

        public void setTypeOfForm(NumberOfForms type)
        {
            _typeOfForm = type;
        }
            
            public bool getTypeOfNumberArrayElemens()
        {
            return _typeOfNumberArrayElements;
        }
        
        public NumberOfForms getNumberOfForms()
        {
            return _typeOfForm;
        }
        
        public int getElementFromArray(int indexRow, int indexColumn)
        {
            return _arrayForShape[indexRow, indexColumn];
        }
        
        public int getNumberOfRows()
        {
            return _arrayForShape.GetLength(0);
        }

        public int getNumberOfColumns()
        {
            return _arrayForShape.GetLength(1);
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

                    int top = _arrayForShape[firsLayerOfArray, i];

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
            Console.WriteLine("Array:");
            if (_typeOfNumberArrayElements == true)
            {
                for (int i = 0; i < _arrayForShape.GetLength(0); i++)
                {
                    for (int j = 0; j < _arrayForShape.GetLength(1); j++)
                    {
                        Console.Write(_arrayForShape[i, j] + "\t");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < _arrayForShape.GetLength(0); i++)
                {
                    for (int j = 0; j < _arrayForShape.GetLength(1); j++)
                    {
                        Console.Write((char)_arrayForShape[i, j] + "\t");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}