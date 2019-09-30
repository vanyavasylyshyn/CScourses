using System;
using System.Text.RegularExpressions;

namespace CSCourseLab3
{
    public abstract class  Shapes
    {
        protected byte[,] _arrayForShape;

        public virtual void generateElementsOfArrayByRandomNumbers() {}
        public virtual void generateElementsOfArrayByRange(int startNumber, int finishNumber) {}
        public virtual void generateElementsOfArrayByAnySymbols() {}
        public virtual void generateElementsOfArrayByEnglishAlphabetSymbols() {}

        public abstract int findMaxElementInTheAreaOfMatrix();
        public abstract int findMinElementInTheAreaOfMatrix();
        public abstract int findSymbolInTheAreaOfMatrix(char symbolToFind);

        public void transposeMatrix()
        {
            byte buffer;
            for (int i = 0; i < _arrayForShape.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    buffer = _arrayForShape[i, j];
                    _arrayForShape[i, j] = _arrayForShape[j, i];
                    _arrayForShape[j, i] = buffer;
                }
            }
        }
        
        //TODO переписати елементи з одної області в іншу
    }
}