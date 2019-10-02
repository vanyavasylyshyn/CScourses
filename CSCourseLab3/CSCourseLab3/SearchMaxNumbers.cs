using System;

namespace CSCourseLab3
{
    public partial class SearchNumbers
    {
        public static char findMaxNumberInTheAreaOfFirstForm(Shapes objectWithArray)
        {
            int maxElement = objectWithArray.getElementFromArray(0, 0);
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j <= i)
                    {
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
            int maxElement = objectWithArray.getElementFromArray(0, 0);

            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j >= i)
                    {
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
            int maxElement = objectWithArray.getElementFromArray(0, 0);
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() - i)
                    {
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
            int maxElement = objectWithArray.getElementFromArray(0, 0);
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j+1 >= objectWithArray.getNumberOfColumns() - i)
                    {
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
            int maxElement = objectWithArray.getElementFromArray(0, 0);
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if ((j < objectWithArray.getNumberOfColumns() - i && j >= i) ||
                        (j <= i && j >= objectWithArray.getNumberOfColumns() - i - 1))
                    {
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
            int maxElement = objectWithArray.getElementFromArray(0, 0);
            
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
            int maxElement = objectWithArray.getElementFromArray(0, 0);
            
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
            int maxElement = objectWithArray.getElementFromArray(0, 0);
            
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
            int maxElement = objectWithArray.getElementFromArray(0, 0);
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j <= i && j >= objectWithArray.getNumberOfColumns() - i - 1 )
                    {
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
            int maxElement = objectWithArray.getElementFromArray(0, 0);
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() - i && j >= i)
                    {
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
            int maxElement = objectWithArray.getElementFromArray(0, 0);
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() - i  || j <= i)
                    {
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
            int maxElement = objectWithArray.getElementFromArray(0, 0);
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() && j >= i ||
                        j <= i && j > objectWithArray.getNumberOfColumns() - i - 2 )
                    {
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
            int maxElement = objectWithArray.getElementFromArray(0, 0);
            
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
            int maxElement = objectWithArray.getElementFromArray(0, 0);
            
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
