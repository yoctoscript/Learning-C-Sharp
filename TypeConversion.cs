using System;

namespace MyTypeConversion
{
    internal class TypeConversion
    {
        public static void Entry()
        {
            Console.WriteLine("Greetings from TypeConversion class!");
            /// Explicit casting is a way to convert a value from one data type to another by explicitly specifying the target data type in parentheses.
            /// Not all data type conversions are allowed by the compiler, and attempting to perform an invalid cast will result in a compile-time error.
            /// Explicit casting in C# can cause potential risks and drawbacks such as data loss, overflow errors, and runtime exceptions, and should be used with caution while considering these factors.
            dynamic myObject = 100;
            const int width = 20;
            /// C# does not allow any conversion from a numeric type to a boolean/string value using a cast operator or any other built-in conversion method.
            try 
            {
                // Console.WriteLine($"{"(bool)", width} {(bool)myObject, width} {(bool)myObject, width:X}");
                // Console.WriteLine($"{"(string)", width} {(string)myObject, width} {(string)myObject, width:X}");
                Console.WriteLine($"{"(char)", width} {(char)myObject, width} {(char)myObject, width:X}");
                Console.WriteLine($"{"(byte)", width} {(byte)myObject, width} {(byte)myObject, width:X}");
                Console.WriteLine($"{"(sbyte)", width} {(sbyte)myObject, width} {(sbyte)myObject, width:X}");
                Console.WriteLine($"{"(short)", width} {(short)myObject, width } {(short)myObject, width:X}");
                Console.WriteLine($"{"(ushort)", width} {(ushort)myObject, width} {(ushort)myObject, width:X}");
                Console.WriteLine($"{"(int)", width} {(int)myObject, width} {(int)myObject, width:X}");
                Console.WriteLine($"{"(uint)", width} {(uint)myObject, width} {(uint)myObject, width:X}");
                Console.WriteLine($"{"(long)", width} {(long)myObject, width} {(long)myObject, width:X}");
                Console.WriteLine($"{"(ulong)", width} {(ulong)myObject, width} {(ulong)myObject, width:X}");
                Console.WriteLine(Color.GREEN);
                Console.WriteLine((int)Color.GREEN);
                Console.WriteLine((Color)1);
                Console.WriteLine(((Color)1).ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        internal enum Color
        {
            RED = 0,
            GREEN = 1,
            BLUE = 2
        }
    }
}