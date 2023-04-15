using System;

namespace MyTypeConversion
{
    internal class TypeConversion
    {
        public static void Entry()
        {
            Console.WriteLine("Greetings from TypeConversion class!");
            /// Explicit casting is a way to convert a value from one data type to another by explicitly specifying the target data type in parentheses.
            /// Explicit conversions require a cast expression. Casting is required when information might be lost in the conversion, or when the conversion might not succeed for other reasons.
            /// Typical examples include numeric conversion to a type that has less precision or a smaller range, and conversion of a base-class instance to a derived class.
            /// Not all data type conversions are allowed by the compiler, and attempting to perform an invalid cast will result in a compile-time error.
            /// Explicit casting in C# can cause potential risks and drawbacks such as data loss, overflow errors, and runtime exceptions, and should be used with caution while considering these factors.
            dynamic myDynamic = 97;
            /// When assigning a value to a dynamic variable, it becomes that type and no boxing occurs.
            /// Dynamic variables are resolved at runtime. The conversions below work fine and no unboxing is needed.
            const int width = 20;
            /// C# does not allow any conversion from a numeric type to a boolean/string value using a cast operator or any other built-in conversion method.
            try 
            {
                // Console.WriteLine($"{"(bool)", width} {(bool)myDynamic, width} {(bool)myDynamic, width:X}");
                // Console.WriteLine($"{"(string)", width} {(string)myDynamic, width} {(string)myDynamic, width:X}");
                Console.WriteLine($"{"(char)", width} {(char)myDynamic, width} {(char)myDynamic, width:X}");
                Console.WriteLine($"{"(byte)", width} {(byte)myDynamic, width} {(byte)myDynamic, width:X}");
                Console.WriteLine($"{"(sbyte)", width} {(sbyte)myDynamic, width} {(sbyte)myDynamic, width:X}");
                Console.WriteLine($"{"(short)", width} {(short)myDynamic, width } {(short)myDynamic, width:X}");
                Console.WriteLine($"{"(ushort)", width} {(ushort)myDynamic, width} {(ushort)myDynamic, width:X}");
                Console.WriteLine($"{"(int)", width} {(int)myDynamic, width} {(int)myDynamic, width:X}");
                Console.WriteLine($"{"(uint)", width} {(uint)myDynamic, width} {(uint)myDynamic, width:X}");
                Console.WriteLine($"{"(long)", width} {(long)myDynamic, width} {(long)myDynamic, width:X}");
                Console.WriteLine($"{"(ulong)", width} {(ulong)myDynamic, width} {(ulong)myDynamic, width:X}");
                Console.WriteLine($"{"(float)", width} {(float)myDynamic, width} {(float)myDynamic, width:F2}");
                Console.WriteLine($"{"(double)", width} {(double)myDynamic, width} {(double)myDynamic, width:F2}");
                Console.WriteLine($"{"(decimal)", width} {(decimal)myDynamic, width} {(decimal)myDynamic, width:F2}");
                Console.WriteLine(Color.GREEN);
                Console.WriteLine((int)Color.GREEN);
                Console.WriteLine((Color)1);
                Console.WriteLine(((Color)1).ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }   
            /// When assigning a value to an object variable, the value is boxed.
            /// If you want it casted to another type, it has to be unboxed first to its original type, then casted to the desired type.
            object myObject = 97;
            Console.WriteLine($"myObject as a character: {(char)((int)myObject)}");
            /// User-defined conversions
            /// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
            /// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/user-defined-conversion-operators
            /// The static methods of the Convert class are primarily used to support conversion to and from the base data types in .NET.
            /// The supported base types are Boolean, Char, SByte, Byte, Int16, Int32, Int64, UInt16, UInt32, UInt64, Single, Double, Decimal, DateTime and String.
            try
            {
                Console.WriteLine($"{"ToBool", width} {Convert.ToBoolean(myDynamic), width}");
                Console.WriteLine($"{"ToString", width} {Convert.ToString(myDynamic), width}");
                Console.WriteLine($"{"ToString (2)", width} {Convert.ToString(myDynamic, 2), width}");
                Console.WriteLine($"{"ToString (8)", width} {Convert.ToString(myDynamic, 8), width}");
                Console.WriteLine($"{"ToString (10)", width} {Convert.ToString(myDynamic, 10), width}");
                Console.WriteLine($"{"ToString (16)", width} {Convert.ToString(myDynamic, 16), width}");
                Console.WriteLine($"{"ToChar", width} {Convert.ToChar(myDynamic), width}");
                Console.WriteLine($"{"ToByte", width} {Convert.ToByte(myDynamic), width}");
                Console.WriteLine($"{"ToSByte", width} {Convert.ToSByte(myDynamic), width}");
                Console.WriteLine($"{"ToInt16", width} {Convert.ToInt16(myDynamic), width}");
                Console.WriteLine($"{"ToUInt16", width} {Convert.ToUInt16(myDynamic), width}");
                Console.WriteLine($"{"ToInt32", width} {Convert.ToInt32(myDynamic), width}");
                Console.WriteLine($"{"ToUInt32", width} {Convert.ToUInt32(myDynamic), width}");
                Console.WriteLine($"{"ToInt64", width} {Convert.ToInt64(myDynamic), width}");
                Console.WriteLine($"{"ToUInt64", width} {Convert.ToUInt64(myDynamic), width}");
                Console.WriteLine($"{"ToSingle", width} {Convert.ToSingle(myDynamic), width}");
                Console.WriteLine($"{"ToDouble", width} {Convert.ToDouble(myDynamic), width}");
                Console.WriteLine($"{"ToDecimal", width} {Convert.ToDecimal(myDynamic), width}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            /// The Parse method is a built-in method that allows you to convert a string representation of a value to its corresponding data type.
            Console.WriteLine($"Parsing bool: {bool.Parse("true")}");
            Console.WriteLine($"Trying to parse char: {char.TryParse("cap", out char result1)}");
            Console.WriteLine($"Parsing byte: {byte.Parse("+100")}");
            Console.WriteLine($"Trying to parse short: {short.TryParse("-1337", out short result2)}");
            Console.WriteLine($"Parsing int: {int.Parse("10")}");
            Console.WriteLine($"Trying to parse long: {long.TryParse("999999999999999999999", out long result3)}");
        }
        internal enum Color
        {
            RED = 0,
            GREEN = 1,
            BLUE = 2
        }
    }
}