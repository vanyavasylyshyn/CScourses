namespace CSCourseLab3
{
    public partial class UserModule
    {
        private static void turnArray(Shapes formToTurn, int numberOfTurns)
        {
            for (int i = 0; i < numberOfTurns; i++)
            {
                formToTurn.transposeArray();
            }
        }
        
        public static void rewriteMethodForFirstShapeType(Shapes formToRewrite, int numberOfFormToRewriteIn)
        {
            switch (formToRewrite.getNumberOfForms())
            {
                case NumberOfForms.FirstForm:
                {
                    switch (numberOfFormToRewriteIn)
                    {
                        case (int)NumberOfForms.SecondForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromFirstToSecondForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.SecondForm);
                        }
                            break;
                        
                        case (int) NumberOfForms.ThirdForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromFirstToThirdForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.TenthForm);
                        }
                            break;

                        case (int)NumberOfForms.FourthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromFirstToFourthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.FourthForm);
                        }
                            break;
                    }
                }
                    break;
                    
                case NumberOfForms.SecondForm:
                {
                    switch (numberOfFormToRewriteIn)
                    {
                        case (int)NumberOfForms.FirstForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromSecondToFirstForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.FirstForm);
                        }
                            break;
                        
                        case (int) NumberOfForms.ThirdForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromSecondToThirdForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.ThirdForm);
                        }
                            break;

                        case (int)NumberOfForms.FourthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromSecondToFourthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.FourthForm);
                        }
                            break;
                    }
                }
                    break;
                
                case NumberOfForms.ThirdForm:
                {
                    switch (numberOfFormToRewriteIn)
                    {
                        case (int)NumberOfForms.FirstForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromThirdToFirstForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.FirstForm);
                        }
                            break;
                        
                        case (int) NumberOfForms.SecondForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromThirdToSecondForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.SecondForm);
                        }
                            break;

                        case (int)NumberOfForms.FourthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromThirdToFourthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.FourthForm);
                        }
                            break;
                    }
                }
                    break;
                
                case NumberOfForms.FourthForm:
                {
                    switch (numberOfFormToRewriteIn)
                    {
                        case (int)NumberOfForms.FirstForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromFourthToFirstForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.FirstForm);
                        }
                            break;
                        
                        case (int) NumberOfForms.SecondForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromFourthToSecondForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.SecondForm);
                        }
                            break;

                        case (int)NumberOfForms.ThirdForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromFourthToThirdForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.ThirdForm);
                        }
                            break;
                    }
                }
                    break;
            }
        }
        
        public static void rewriteMethodForSecondShapeType(Shapes formToRewrite, int numberOfFormToRewriteIn)
        {
            switch (formToRewrite.getNumberOfForms())
            {
                case NumberOfForms.FifthForm:
                {
                    if (numberOfFormToRewriteIn == (int)NumberOfForms.SixthForm)
                    {
                        turnArray(formToRewrite, Config.NumberOfTurnsFromFifthToSixthForms);
                        formToRewrite.setTypeOfForm(NumberOfForms.SixthForm);
                    }
                }
                    break;
                    
                case NumberOfForms.SixthForm:
                {
                    if (numberOfFormToRewriteIn == (int)NumberOfForms.FifthForm)
                    {
                        turnArray(formToRewrite, Config.NumberOfTurnsFromSixthToFifthForms);
                        formToRewrite.setTypeOfForm(NumberOfForms.FifthForm);
                    }
                }
                    break;
            }
        }
        
        
        public static void rewriteMethodForThirdShapeType(Shapes formToRewrite, int numberOfFormToRewriteIn)
        {
            switch (formToRewrite.getNumberOfForms())
            {
                case NumberOfForms.SeventhForm:
                {
                    switch (numberOfFormToRewriteIn)
                    {
                        case (int)NumberOfForms.EighthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromSeventhToEightForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.EighthForm);
                        }
                            break;
                        
                        case (int) NumberOfForms.NinthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromSeventhToNinthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.NinthForm);
                        }
                            break;

                        case (int)NumberOfForms.TenthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromSeventhToTenthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.TenthForm);
                        }
                            break;
                    }
                }
                    break;
                
                case NumberOfForms.EighthForm:
                {
                    switch (numberOfFormToRewriteIn)
                    {
                        case (int)NumberOfForms.SeventhForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromEightToSevenForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.SeventhForm);
                        }
                            break;
                        
                        case (int) NumberOfForms.NinthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromEightToNinthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.NinthForm);
                        }
                            break;

                        case (int)NumberOfForms.TenthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromEightToTenthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.TenthForm);
                        }
                            break;
                    }
                }
                    break;
                
                case NumberOfForms.NinthForm:
                {
                    switch (numberOfFormToRewriteIn)
                    {
                        case (int)NumberOfForms.SeventhForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromNinthToSevenForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.SeventhForm);
                        }
                            break;
                        
                        case (int) NumberOfForms.EighthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromNinthToEightForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.EighthForm);
                        }
                            break;

                        case (int)NumberOfForms.TenthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromNinthToTenthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.TenthForm);
                        }
                            break;
                    }
                }
                    break;
                
                case NumberOfForms.TenthForm:
                {
                    switch (numberOfFormToRewriteIn)
                    {
                        case (int)NumberOfForms.SeventhForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromTenthToSevenForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.SeventhForm);
                        }
                            break;
                        
                        case (int) NumberOfForms.EighthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromTenthToEightForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.EighthForm);
                        }
                            break;

                        case (int)NumberOfForms.NinthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromTenthToNinthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.NinthForm);
                        }
                            break;
                    }
                }
                    break;
            }
        }

        public static void rewriteMethodForFourthShapeType(Shapes formToRewrite, int numberOfFormToRewriteIn)
        {
            switch (formToRewrite.getNumberOfForms())
            {
                case NumberOfForms.EleventhForm:
                {
                    switch (numberOfFormToRewriteIn)
                    {
                        case (int)NumberOfForms.TwelfthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromEleventhToTwelfthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.TwelfthForm);
                        }
                            break;
                        
                        case (int) NumberOfForms.ThirteenthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromEleventhToThirteenthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.ThirteenthForm);
                        }
                            break;

                        case (int)NumberOfForms.FourteenthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromEleventhToFourteenthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.FourteenthForm);
                        }
                            break;
                    }
                }
                    break;
                
                case NumberOfForms.TwelfthForm:
                {
                    switch (numberOfFormToRewriteIn)
                    {
                        case (int)NumberOfForms.EleventhForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromTwelfthToEleventhForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.EleventhForm);
                        }
                            break;
                        
                        case (int) NumberOfForms.ThirteenthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromTwelfthToThirteenthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.ThirteenthForm);
                        }
                            break;

                        case (int)NumberOfForms.FourteenthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromTwelfthToFourteenthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.FourteenthForm);
                        }
                            break;
                    }
                }
                    break;
                
                case NumberOfForms.ThirteenthForm:
                {
                    switch (numberOfFormToRewriteIn)
                    {
                        case (int)NumberOfForms.EleventhForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromThirteenthToEleventhForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.EleventhForm);
                        }
                            break;
                        
                        case (int) NumberOfForms.TwelfthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromThirteenthToTwelfthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.TwelfthForm);
                        }
                            break;

                        case (int)NumberOfForms.FourteenthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromThirteenthToFourteenthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.FourteenthForm);
                        }
                            break;
                    }
                }
                    break;
                
                case NumberOfForms.FourteenthForm:
                {
                    switch (numberOfFormToRewriteIn)
                    {
                        case (int)NumberOfForms.EleventhForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromFourteenthToEleventhForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.EleventhForm);
                        }
                            break;
                        
                        case (int) NumberOfForms.TwelfthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromFourteenthToTwelfthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.TwelfthForm);
                        }
                            break;

                        case (int)NumberOfForms.ThirteenthForm:
                        {
                            turnArray(formToRewrite, Config.NumberOfTurnsFromFourteenthToThirteenthForms);
                            formToRewrite.setTypeOfForm(NumberOfForms.ThirteenthForm);
                        }
                            break;
                    }
                }
                    break;
            }
        }
    }
}