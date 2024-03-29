namespace CSCourseLab3
{
    public partial class SearchNumbers
    {
        public static int findMinNumberInTheAreaOfFirstForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int minElement = 0;
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j <= i)
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i , j) < minElement)
                        {
                            minElement = objectWithArray.getElementFromArray(i , j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return minElement;
        }
        
        public static int findMinNumberInTheAreaOfSecondForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int minElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j >= i)
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) < minElement)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            
            return minElement;
        }
        
        public static int findMinNumberInTheAreaOfThirdForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int minElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() - i)
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) < minElement)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return minElement;
        }
        
        public static int findMinNumberInTheAreaOfFourthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int minElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j+1 >= objectWithArray.getNumberOfColumns() - i)
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) < minElement)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return minElement;
        }
        
        public static int findMinNumberInTheAreaOfFifthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int minElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if ((j < objectWithArray.getNumberOfColumns() - i && j >= i) ||
                        (j <= i && j >= objectWithArray.getNumberOfColumns() - i - 1))
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) < minElement)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return minElement;
        }
        
        public static int findMinNumberInTheAreaOfSixthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int minElement = 0;
            
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
                            minElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) < minElement)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                }
            }

            return minElement;
        }
        
        public static int findMinNumberInTheAreaOfSeventhForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int minElement = 0;
            
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
                            minElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) < minElement)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                }
            }
            
            return minElement;
        }
        
        public static int findMinNumberInTheAreaOfEigthtForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int minElement = 0;
            
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
                            minElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) < minElement)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                }
            }

            return minElement;
        }
        
        public static int findMinNumberInTheAreaOfNingthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int minElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j <= i && j >= objectWithArray.getNumberOfColumns() - i - 1 )
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) < minElement)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            
            return minElement;
        }
        
        public static int findMinNumberInTheAreaOfTenthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int minElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() - i && j >= i)
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) < minElement)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return minElement;
        }
        
        public static int findMinNumberInTheAreaOfEleventhForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int minElement = 0;
            
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() - i  || j <= i)
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) < minElement)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return minElement;
        }
        
        public static int findMinNumberInTheAreaOfTwelfthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int minElement = 0;

            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() && j >= i ||
                        j <= i && j > objectWithArray.getNumberOfColumns() - i - 2 )
                    {
                        if (counterForCreatingFirstElement < 1)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) < minElement)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return minElement;
        }
        
        public static int findMinNumberInTheAreaOfThirteenthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int minElement = 0;
            
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
                            minElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) < minElement)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                }
            }

            return minElement;
        }
        
        public static int findMinNumberInTheAreaOfFourteenthForm(Shapes objectWithArray)
        {
            byte counterForCreatingFirstElement = 0;
            int minElement = 0;
            
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
                            minElement = objectWithArray.getElementFromArray(i, j);
                            counterForCreatingFirstElement++;
                        }
                        
                        if (objectWithArray.getElementFromArray(i, j) < minElement)
                        {
                            minElement = objectWithArray.getElementFromArray(i, j);
                        }
                    }
                }
            }
            
            return minElement;
        }
    }
}