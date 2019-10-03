using System;

namespace CSCourseLab3
{
    public class SearchSymbols
    {
        public static bool findSymbolInTheAreaOfFirstForm(Shapes objectWithArray, char symbolToFind)
        {
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j <= i)
                    {
                        if (symbolToFind == objectWithArray.getElementFromArray(i, j))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return false;
        }
        
        public static bool findSymbolInTheAreaOfSecondForm(Shapes objectWithArray, char symbolToFind)
        {
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j >= i)
                    {
                        if (symbolToFind == objectWithArray.getElementFromArray(i, j))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return false;
        }
        
        public static bool findSymbolInTheAreaOfThirdForm(Shapes objectWithArray, char symbolToFind)
        {
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() - i)
                    {
                        if (symbolToFind == objectWithArray.getElementFromArray(i, j))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            
            return false;
        }
        
        public static bool findSymbolInTheAreaOfFourthForm(Shapes objectWithArray, char symbolToFind)
        {
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j+1 >= objectWithArray.getNumberOfColumns() - i)
                    {
                        if (symbolToFind == objectWithArray.getElementFromArray(i, j))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return false;
        }
        
        public static bool findSymbolInTheAreaOfFifthForm(Shapes objectWithArray, char symbolToFind)
        {
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if ((j < objectWithArray.getNumberOfColumns() - i && j >= i) ||
                        (j <= i && j >= objectWithArray.getNumberOfColumns() - i - 1))
                    {
                        if (symbolToFind == objectWithArray.getElementFromArray(i, j))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return false;
        }
        
        public static bool findSymbolInTheAreaOfSixthForm(Shapes objectWithArray, char symbolToFind)
        {
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
                        if (symbolToFind == objectWithArray.getElementFromArray(i, j))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        
        public static bool findSymbolInTheAreaOfSeventhForm(Shapes objectWithArray, char symbolToFind)
        {
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
                        if (symbolToFind == objectWithArray.getElementFromArray(i, j))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        
        public static bool findSymbolInTheAreaOfEghthForm(Shapes objectWithArray, char symbolToFind)
        {
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
                        if (symbolToFind == objectWithArray.getElementFromArray(i, j))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        
        public static bool findSymbolInTheAreaOfNinthForm(Shapes objectWithArray, char symbolToFind)
        {
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j <= i && j >= objectWithArray.getNumberOfColumns() - i - 1 )
                    {
                        if (symbolToFind == objectWithArray.getElementFromArray(i, j))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return false;
        }
        
        public static bool findSymbolInTheAreaOfTenthForm(Shapes objectWithArray, char symbolToFind)
        {
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() - i && j >= i)
                    {
                        if (symbolToFind == objectWithArray.getElementFromArray(i, j))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return false;
        }
        
        public static bool findSymbolInTheAreaOfEleventhForm(Shapes objectWithArray, char symbolToFind)
        {
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() - i  || j <= i)
                    {
                        if (symbolToFind == objectWithArray.getElementFromArray(i, j))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return false;
        }
        
        public static bool findSymbolInTheAreaOfTwelfthForm(Shapes objectWithArray, char symbolToFind)
        {
            for (int i = 0; i < objectWithArray.getNumberOfRows(); i++)
            {
                for (int j = 0; j < objectWithArray.getNumberOfColumns(); j++)
                {
                    if (j < objectWithArray.getNumberOfColumns() && j >= i ||
                        j <= i && j > objectWithArray.getNumberOfColumns() - i - 2 )
                    {
                        if (symbolToFind == objectWithArray.getElementFromArray(i, j))
                        {
                            return true;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return false;
        }
        
        public static bool findSymbolInTheAreaOfThirteenthForm(Shapes objectWithArray, char symbolToFind)
        {
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
                        if (symbolToFind == objectWithArray.getElementFromArray(i, j))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        
        public static bool findSymbolInTheAreaOfFourteenthForm(Shapes objectWithArray, char symbolToFind)
        {
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
                        if (symbolToFind == objectWithArray.getElementFromArray(i, j))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}