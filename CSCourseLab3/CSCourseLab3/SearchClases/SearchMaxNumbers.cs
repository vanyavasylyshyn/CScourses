using System;

namespace CSCourseLab3
{
    public partial class SearchNumbers
    {
        public static char findMaxNumberInTheAreaOfFirstForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int maxElement = 0;
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j <= i)
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i , j) > maxElement)
                        {
                            maxElement = objectWithArray.getElementFromArray(i , j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return (char)maxElement;
        }
        
        public static char findMaxNumberInTheAreaOfSecondForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int maxElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j >= i)
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) > maxElement)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return (char)maxElement;
        }
        
        public static char findMaxNumberInTheAreaOfThirdForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int maxElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() - i)
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) > maxElement)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return (char)maxElement;
        }
        
        public static char findMaxNumberInTheAreaOfFourthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int maxElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j+1 >= objectWithArray.getNumberOfColumns() - i)
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) > maxElement)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return (char)maxElement;
        }
        
        public static char findMaxNumberInTheAreaOfFifthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int maxElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if ((j < objectWithArray.getNumberOfColumns() - i && j >= i) ||
                        (j <= i && j >= objectWithArray.getNumberOfColumns() - i - 1))
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) > maxElement)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return (char)maxElement;
        }
        
        public static char findMaxNumberInTheAreaOfSixthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int maxElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if ((j < objectWithArray.getNumberOfColumns() - i - 1 && j > i) ||
                        (j < i && j > objectWithArray.getNumberOfColumns() - i - 1))
                    {
                        continue;
                    }
                    else
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) > maxElement)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                }
            }

            return (char)maxElement;
        }
        
        public static char findMaxNumberInTheAreaOfSeventhForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int maxElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if ((j < objectWithArray.getNumberOfColumns() && j > i) ||
                        (j <= i && j > objectWithArray.getNumberOfColumns() - i - 1 ))
                    {
                        continue;
                    }
                    else
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) > maxElement)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                }
            }

            return (char)maxElement;
        }
        
        public static char findMaxNumberInTheAreaOfEighthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int maxElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if ((j < objectWithArray.getNumberOfColumns() - i - 1) || (j < i))
                    {
                        continue;
                    }
                    else
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) > maxElement)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                }
            }

            return (char)maxElement;
        }
        
        public static char findMaxNumberInTheAreaOfNinthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int maxElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j <= i && j >= objectWithArray.getNumberOfColumns() - i - 1 )
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) > maxElement)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return (char)maxElement;
        }
        
        public static char findMaxNumberInTheAreaOfTenthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int maxElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() - i && j >= i)
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) > maxElement)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return (char)maxElement;
        }
        
        public static char findMaxNumberInTheAreaOfEleventhForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int maxElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() - i  || j <= i)
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) > maxElement)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return (char)maxElement;
        }
        
        public static char findMaxNumberInTheAreaOfTwelfthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int maxElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() && j >= i ||
                        j <= i && j > objectWithArray.getNumberOfColumns() - i - 2 )
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) > maxElement)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return (char)maxElement;
        }
        
        public static char findMaxNumberInTheAreaOfThirteenthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int maxElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < i && j >= objectWithArray.getNumberOfColumns() - i )
                    {
                        continue;
                    }
                    else
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) > maxElement)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                }
            }

            return (char)maxElement;
        }
        
        public static char findMaxNumberInTheAreaOfFourteenthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int maxElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() - i - 1 && j > i)
                    {
                        continue;
                    }
                    else
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) > maxElement)
                        {
                            maxElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                }
            }

            return (char)maxElement;
        }
    }
}
