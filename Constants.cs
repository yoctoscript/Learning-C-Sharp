using System;

namespace MyConstants
{
    internal class Constants
    {
        public static void Entry()
        {
            /// Integer literals.
            int myInt1 = 420, myInt2 = 0b1011;
            long myLong1 = 0xFEEL, myLong2 = (long)13U;
            /// Floating point literals.
            float myFloat1 = .2F, myFloat2 = 5F;
            double myDouble1 = 9e-18d, myDouble2 = 0.18e10;
            /// Character literals
            /// http://russellcottrell.com/greek/utilities/SurrogatePairCalculator.htm
            /// Unicode characters that have codes greater than 0xFFFF require two 16-bit code units, called surrogates, to represent them in memory.
            /// These surrogates are also called high and low surrogates or surrogate pairs.
            string myString = "🔥";
            int code = char.ConvertToUtf32(myString, 0); /// Represents the unicode code point as 32-bit integer.
            code -= 0x10000;
            int highSurrogateCode = (code / 0x400) + 0xD800;
            int lowSurrogateCode = (code % 0x400) + 0xDC00;
            /// Casting an integer value to <char> produces a unicode character.
            string emoji = $"{(char)highSurrogateCode}{(char)lowSurrogateCode}";
            Console.WriteLine(emoji);
            /// String literals.
            string myString1 = @$"This is a multi-line string.
It contains ""multiples"" lines, it's {"awesome"}.
Here's a brace for y'all {{}}";
            string myString2 = "hi"+"bye";
            Console.WriteLine(myString1);
            /// Constants
            const decimal myDecimal1 = 120.12m;
        }
    }
}