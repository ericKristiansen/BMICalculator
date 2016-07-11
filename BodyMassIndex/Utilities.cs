using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Project: BMI Calculator
Programmer: Eric Kristiansen
Date: 7/11/16
*/
namespace Util
{
    /// <summary>
    /// This is just a basic class to host commonly used values
    /// </summary>
    public static class Utilities
    {
        public static int ZERO => 0;
        public static int NEGATIVE_ONE => -1;
        public static int ONE => 1;
        public static string ZERO_DOT_ZERO => "0.0";
        public static string ZERO_BALANCE => "0.00";
        public static string FORMAT_2_DECIMAL_STRING => "{0:0.00}";
        public static string FORMAT_1_DECIMAL_STRING => "{0:0.0}";
        public static string CURRENCY_FORMAT_STRING => "{0:C}";
        public static int SQUARE_EXPONENT => 2;
    }
}
