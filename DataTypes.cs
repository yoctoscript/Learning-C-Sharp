/// The terms "class" and "type" are often used interchangeably, but there is a subtle difference between the two.
/// A class is a construct in C# that defines the blueprint for creating objects, specifying the fields, properties, methods, and events that an object of that class can have.
/// On the other hand, a type is a broader concept that includes not only classes but also other constructs like interfaces, structs, enums, and delegates.
/// While all classes are types, not all types are classes. Each object in C# has a specific type, which determines its capabilities and behavior.

using System;
using System.Text;
namespace MyDataTypes
{
    internal class DataTypes
    {
        public static void Entry()
        {   
            Console.WriteLine("Hello World from DataTypes Class");
            /// A value type is a data type that stores its value directly in memory.
            /// This means that when you assign a value type variable to another variable, the second variable gets a copy of the first variable's value, and any changes made to the second variable won't affect the first.
            /// Examples of value types include int, float, double, bool, and char.
            bool myBool = true;
            myBool = false;
            char myChar = '\0';
            myChar = '\"';
            byte myByte = 255;
            myByte = 0;
            sbyte mySignedByte = 127;
            mySignedByte = -127;
            /// You can use underscores to separate groups of digits in numeric literals for improved readability.
            /// However, underscores cannot be placed at the beginning or end of the literal, next to the decimal point, or in literals with a base other than 10.
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
            /// A reference type, on the other hand, stores a reference (a pointer) to a memory location where the actual value is stored.
            /// This means that when you assign a reference type variable to another variable, both variables point to the same memory location, and any changes made to the second variable will affect the first.
            /// Examples of reference types include classes, arrays, and strings.
            string myString = "Hello " + "C#";
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
            /// The original value type variable is now referencing the newly created object.
            int i = 420;
            ++i;
            object myObject = i; /// boxing
            int j = myObject as int? ?? 0; /// unboxing
            Console.WriteLine($"{i}, {j}");
            /// When you use the dynamic type, the compiler defers the type checking to runtime and resolves method and property calls based on the actual type of the object.
            dynamic myDynamicObject = "Some Data";
            Console.WriteLine(myDynamicObject.Length);

        }
    }
}

/// Value types store their value directly in memory, while reference types store a reference to a memory location where the actual value is stored.
/// When you assign a value type variable to another variable, the second variable gets a copy of the first variable's value. When you assign a reference type variable to another variable, both variables point to the same memory location.
/// Value types are generally more efficient in terms of memory usage and performance, while reference types can be more flexible and allow for more complex data structures and object-oriented programming.

