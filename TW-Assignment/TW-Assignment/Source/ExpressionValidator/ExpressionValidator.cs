using System;

namespace TW_Assignment.Source.ExpressionValidator
{
    public static class ExpressionValidator
    {
        public  static bool Validate(string expression)
        {
            const char LeftParenthesis = '(';
            const char RightParenthesis = ')';
            const char LeftBracket = '[';
            const char RightBracket = ']';
            const char LeftFlowerBr = '{';
            const char RightFlowerBr = '}';
            uint ParanthesisCount = 0;
            uint BracketCount = 0;
            uint FlowerBrCount = 0;


            try
            {
                checked 
                {
                    for (int Index = 0; Index < expression.Length; Index++)
                    {
                        switch (expression[Index])
                        {
                            case LeftParenthesis:
                                ParanthesisCount++;
                                continue;
                            case RightParenthesis:
                                ParanthesisCount--;
                                continue;
                            case LeftBracket:
                                BracketCount++;
                                continue;
                            case RightBracket:
                                BracketCount--;
                                continue;

                            case LeftFlowerBr:
                                FlowerBrCount++;
                                continue;

                            case RightFlowerBr:
                                FlowerBrCount--;
                                continue;
                            default:
                                continue;
                        }

                    }
                }
            }

            catch (OverflowException)
            {
                return false;
            }

            if (ParanthesisCount == 0)
            {
                return true;
            }

            return false;
        }
    }
}
