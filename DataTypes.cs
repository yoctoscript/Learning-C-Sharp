/// A type defines the characteristics and behavior of an object.
/// It specifies the values that an object can hold, the operations that can be performed on those values, and the memory layout of the object.
/// C# supports several types:
///     Value types: bool, byte, sbyte, char, decimal, double, float, int, uint, long, ulong, short, ushort.
///     Reference types: object, string, dynamic.
///     Pointer types: Pointer, IntPtr, UIntPtr.
///     Derived types: class, interface, delegate, array, enum, struct.
///     Nullable value types: bool?, byte?, sbyte?, char?, decimal?, double?, float?, int?, uint?, long?, ulong?, short?, ushort?.

using System;
using System.Text;
namespace MyDataTypes
{
    internal class DataTypes
    {
        public static void Entry()
        {   
            Console.WriteLine("Greetings from DataTypes class!");
            /// A value type is a data type that stores its value directly in the memory allocated on the stack to the variable holding it.
            /// When you assign a value type variable to another variable, the second variable receives a copy of the value stored in the first variable. This means that any changes made to the second variable won't affect the value stored in the first variable.
            bool myBool = true;
            myBool = false;
            char myChar = '\0'; /// 16-bit unicode character.
            myChar = '\"';
            byte myByte = 255;
            myByte = 0;
            sbyte mySignedByte = 127;
            mySignedByte = -127;
            /// Underscores can be used to group digits in numeric literals for improved readability.
            /// Underscores can be used within decimal integers, octal, and hexadecimal literals, as well as float, double, and decimal type literals. However, they cannot be placed at the beginning or end of the literal or next to the decimal point.
            short myShort = 32_767;
            myShort = -32_768;
            ushort myUnsignedShort = 65_535;
            myUnsignedShort = 0;
            int myInt = 2_147_483_647;
            myInt = -2_147_483_648;
            uint myUnsignedInt = 4_294_967_295;
            myUnsignedInt = 0;
            long myLong = 9_223_372_036_854_775_807;
            myLong = -9_223_372_036_854_775_808;
            ulong myUnsignedLong = 18_446_744_073_709_551_615;
            myUnsignedLong = 0;
            Console.WriteLine($"Bool type: Size = {sizeof(bool)}, Values = {true}, {false}");
            Console.WriteLine($"Char type: Size = {sizeof(char)}, Values e.g. = {'\"'}, {'\\'}, {'$'}, {'!'}, {'1'}, {'y'}, {'ㅂ'}, {'Ω'}, {'ß'}, {'আ'}");
            Console.WriteLine($"Byte type: Size = {sizeof(byte)}, Max = {byte.MaxValue}, Min = {byte.MinValue}");
            Console.WriteLine($"SByte type: Size = {sizeof(sbyte)}, Max = {sbyte.MaxValue}, Min = {sbyte.MinValue}");
            Console.WriteLine($"Short type: Size = {sizeof(short)}, Max = {short.MaxValue}, Min = {short.MinValue}");
            Console.WriteLine($"UShort type: Size = {sizeof(ushort)}, Max = {ushort.MaxValue}, Min = {ushort.MinValue}");
            Console.WriteLine($"Int type: Size = {sizeof(int)}, Max = {int.MaxValue}, Min = {int.MinValue}");
            Console.WriteLine($"UInt type: Size = {sizeof(uint)}, Max = {uint.MaxValue}, Min = {uint.MinValue}");
            Console.WriteLine($"Long type: Size = {sizeof(long)}, Max = {long.MaxValue}, Min = {long.MinValue}");
            Console.WriteLine($"ULong type: Size = {sizeof(ulong)}, Max = {ulong.MaxValue}, Min = {ulong.MinValue}");
            /// A reference type is a data type that stores a reference (a pointer) to a memory location on the heap where the actual value is stored.
            /// When you assign a reference type variable to another variable, both variables refer to the same memory location. This means that any modifications made to the second variable will affect the first variable as well.
            string myString = "Hello " + "C#";
            /// A verbatim string is denoted by the @ character prefix.
            /// Verbatim strings are useful when you need to include special characters or escape sequences in your string literals without having to escape them with the backslash (\) character.
            string myPath = @"C:\Program Files\C#\Learning-C-Sharp";
            string harder = "harder";
            string myInterpolatedString = $"{"Why"} {"make"} {"things"} {harder}";
            string name = "Yoctoscript", age = "23";
            string myFormattedString = string.Format("My name's {0} and I'm {1} years old.", name, age);
            StringBuilder sb = new StringBuilder();
            sb.Append("Buildin' ").Append("strings");
            Console.WriteLine(myString);
            Console.WriteLine(myPath);
            Console.WriteLine(myInterpolatedString);
            Console.WriteLine(myFormattedString);
            Console.WriteLine(sb.ToString());
            /// Boxing is the process of converting a value type to an object reference type. 
            /// When a value type is boxed, a new object is created on the heap to hold the value, and a reference to that object is returned.
            /// The original value type variable is not updated to reference the newly created object.
            int myInteger1 = 420;
            unsafe
            {
                int* intPointer1 = &myInteger1;
                Console.WriteLine($"Value of i = {myInteger1}, Address = {(ulong)intPointer1:X}");
            }
            object myObject = myInteger1; /// boxing
            unsafe
            {
                object* objectPointer = &myObject;
                Console.WriteLine($"Value of myObject = {myObject}, Address = {(ulong)objectPointer:X}");
            }
            unsafe
            {
                int* intPointer2 = &myInteger1;
                Console.WriteLine($"Value of i = {myInteger1}, Address = {(ulong)intPointer2:X}");
            }
            int myInteger2 = myObject as int? ?? 0; /// unboxing
            Console.WriteLine($"{myInteger1}, {myInteger2}");
            /// When you use the dynamic type, the compiler defers the type checking to runtime and resolves method and property calls based on the actual type of the object.
            dynamic myDynamicObject = 10;
            myDynamicObject += 11;
            myDynamicObject += " twenty-one";
            Console.WriteLine(myDynamicObject);
            /// The default behavior for integer arithmetic operations is "unchecked", which means that the compiler does not generate extra code to check for overflow at runtime.
            /// If an overflow occurs, the result is truncated to fit within the limits of the data type by wrapping around to the minimum value that the data type can hold.
            /// The "checked" keyword ensures that overflow checking is enabled for the block of code that follows it.
            checked
            {
                try
                {
                    int willOverflow1 = int.MaxValue;
                    ++willOverflow1;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine($"Overflow happened. {e.Message}");
                }
            }
            /// Conversely, the "unchecked" keyword is used to explicitly disable overflow checking for a specific block of code.
            unchecked
            {
                byte willOverflow2 = byte.MaxValue;
                ++willOverflow2;
                Console.WriteLine("No exception thrown.");
            }
            /// A "float" is a 32-bit floating point number with a precision of about 7 digits.
            float myFloat = 0.1_234_567F;
            Console.WriteLine($"myFloat = {myFloat}");
            Console.WriteLine($"Float type: Size = {sizeof(float)}, Max = {float.MaxValue}, Min = {float.MinValue}");
            /// A "double" is a 64-bit floating point number with a precision of about 15-16 digits.
            double myDouble = 0.12_345_678_912_345_678D;
            Console.WriteLine($"myDouble = {myDouble}");
            Console.WriteLine($"Double type: Size = {sizeof(double)}, Max = {double.MaxValue}, Min = {double.MinValue}");
            /// A "decimal" is a 128-bit decimal floating point number with a precision of about 28-29 digits.
            decimal myDecimal = 0.1_234_567_891_234_567_891_234_567_891M;
            Console.WriteLine($"myDecimal = {myDecimal}");
            Console.WriteLine($"Decimal type: Size = {sizeof(decimal)}, Max = {decimal.MaxValue}, Min = {decimal.MinValue}");
            /// Writing binary numbers.
            byte myBinary = 0b1011;
            Console.WriteLine($"myBinary = {myBinary}");
            /// C# does not have a built-in support for explicit octal literals.
            /// Writing hexadecimal numbers.
            byte myHex = 0x12;
            Console.WriteLine($"myHex = {myHex}");
            /// Standard numeric format strings: {variable[,width][:formatString]}
            /// "D". Result: Integer digits with optional negative sign. Supported by: Integral types only. Precision specifier: Minimum number of digits.
            Console.WriteLine($"{1945:D10}");
            /// "N". Result: Integral and decimal digits, group seperators, and a decimal seperator with optional negative sign. Support by: All numeric types. Precision specifier: Desired number of decimal places.
            Console.WriteLine($"{1000000.9999:N2}");
            /// "C". Result: Currency value. Support by: All numeric types. Precision specifier: Number of decimal digits.
            Console.WriteLine($"{10000.3668:C4}");
            /// "F". Result: Integral and decimal digits with optional negative sign. Supported by: All numeric types. Precision specifier: Number of decimal digits.
            Console.WriteLine($"{1337.1337:F2}");
            /// "P". Result: Number multiplied by 100 and displayed with a percent symbol. Supported by: All numeric types. Precision specifier: Desired number of decimal places.
            Console.WriteLine($"{0.756:P2}");
            /// "X". Result: Hexadecimal string. Supported by: Integral types only. Precision specifier: Number of digits in the result string.
            Console.WriteLine($"{465:X10}");
            /// "E". Result: Exponential notation. Supported by: All numeric types. Precision specifier: Number of decimal digits.
            Console.WriteLine($"{1.33333:E10}");
            /// Left alignment 
            Console.WriteLine($"[{"I'm left aligned",-40}]");
            /// Right alignment
            Console.WriteLine($"[{"I'm right aligned", 40}]");
        }
    }
}