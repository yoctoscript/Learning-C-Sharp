using System;

namespace MyVariables
{
    internal class Variables
    {
        public static void Entry()
        {
            Console.WriteLine("Greetings from MyVariables class!");
            /// Integral types are a set of datatypes used to represent whole numbers.
            byte myByte1, myByte2 = 0, myByte3 = 100;
            int myInt1 = 1, myInt2 = 31;
            long myLong1, myLong2, myLong3 = 111;
            /// Floating point numbers are represented using the 'float' and 'double' data types.
            /// They are stored using a binary representation of the number, with a fixed number of bits reserved for the mantissa,exponent, and sign.
            /// This means that floating point numbers have limited precision and can sometimes lead to rounding errors, especially when performing calculations that involve many decimal places.
            float myFloat1 = 3.1415f, myFloat2 = 0.00004f;
            double myDouble1 = 0.36d, myDouble2 = 420.69d * 1337d;
            /// Decimal numbers are represented using the 'decimal' data type.
            /// They are stored using a decimal representation of the number with a fixed number of bits reserved for the mantissa, exponent, and sign.
            /// This allows decimal numbers to have high precision than floating point numbers, making them ideal for financial and scientific calculations where precision is critical.
            decimal myDecimal1 = -10.00001m;
            const int width = 18;
            unsafe
            {
                decimal* myDecimalPointer = &myDecimal1;
                Console.WriteLine($"{"Decimal value = ", width} {*myDecimalPointer, width} {"Address of = ", width} {((int)myDecimalPointer), width:X}");
                /// The number in the middle of the flags represents the scale of the decimal value. (Number of digits to the right of the decimal point)
                /// The first high order bit represents the sign
                int* myFlags = (int*)(myDecimalPointer);
                /// First bit of flags determines the sign of the number
                Console.WriteLine($"{"Flags value = ", width} {*myFlags, width:X} {"Address of = ", width} {((int)myFlags), width:X}");
                /// Highest part
                int* myHigh = ++myFlags;
                Console.WriteLine($"{"High value = ", width} {*myHigh, width} {"Address of = ", width} {((int)myHigh), width:X}");
                /// Lowest part
                int* myLow = ++myHigh;
                Console.WriteLine($"{"Low value = ", width} {*myLow, width} {"Address of = ", width} {((int)myLow), width:X}");
                /// Middle part               
                int* myMid = ++myLow;
                Console.WriteLine($"{"Mid value = ", width} {*myMid, width} {"Address of = ", width} {((int)myMid), width:X}");
                decimal myNewDecimal = new decimal(1000001, 0, 0, 2 > 1, (byte)5);
                Console.WriteLine(myNewDecimal);
                /// The Decimal type stores the whole number as a 96-bit integer, with the least significant 64 bits representing the value and the most significant 32 bits representing the scale.
                /// The scale indicates the position of the decimal point in the value.
            }
           /// 
           string myString = null;

        }
    }
}