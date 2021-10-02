using System;
using System.Collections.Generic;

namespace MarsRoverMoveApp
{
    public static class ValidateEnteredValues
    {
        public static Exception Validate(List<string> MaxLimit, List<string> BeginPosition)
        {
            if (MaxLimit.Count != 2)
                return new Exception("Please Enter 2 Values From Max Limit");
            for (int i = 0; i < MaxLimit.Count; i++)
                if (!int.TryParse(MaxLimit[i], out int integerValue))
                    return new Exception("Please Enter Numeric Characters For Max Limit");
            if (BeginPosition.Count != 3)
                return new Exception("Please Enter 3 Values From Begin Position");
            for (int i = 0; i < 2; i++)
                if (!int.TryParse(BeginPosition[i], out int integerValue))
                    return new Exception("Please Enter First and Second Characters Numeric For Begin Position");
            return null;
        }
    }
}
