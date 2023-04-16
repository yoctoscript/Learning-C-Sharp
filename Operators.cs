using System;

namespace MyOperators
{
    internal class Operators
    {
        internal static void Entry()
        {
            Console.WriteLine("Greetings from Operators class!");
            sbyte myByteA = 41, myByteB = -50, myByteC;
            bool myBoolTrue = true, myBoolFalse = false;
            /// Arithmetic operators.
            Console.WriteLine($"{myByteA} + {myByteB} :  {myByteA + myByteB}");
            Console.WriteLine($"{myByteA} - {myByteB} : {myByteA - myByteB}");
            Console.WriteLine($"{myByteA} * {myByteB} :  {myByteA * myByteB}");
            Console.WriteLine($"{myByteA} / {myByteB} : {myByteA / myByteB}");
            Console.WriteLine($"{myByteA} % {myByteB} : {myByteA % myByteB}");
            myByteC = myByteA;
            Console.WriteLine($"++{myByteC} : {++myByteC}");
            myByteC = myByteA;
            Console.WriteLine($"{myByteC}-- : {myByteC++}");
            myByteC = myByteB;
            Console.WriteLine($"--{myByteC} : {--myByteC}");
            myByteC = myByteB;
            Console.WriteLine($"{myByteC}-- : {myByteC--}");
            /// Relational operators.
            Console.WriteLine($"{myByteA} == {myByteB} : {myByteA == myByteB}");
            Console.WriteLine($"{myByteA} != {myByteB} : {myByteA != myByteB}");
            Console.WriteLine($"{myByteA} > {myByteB} : {myByteA > myByteB}");
            Console.WriteLine($"{myByteA} >= {myByteB} : {myByteA >= myByteB}");
            Console.WriteLine($"{myByteA} < {myByteB} : {myByteA < myByteB}");
            Console.WriteLine($"{myByteA} <= {myByteB} : {myByteA <= myByteB}");
            /// Logical operators.
            Console.WriteLine($"{myBoolTrue} && {myBoolFalse} : {myBoolTrue  && myBoolFalse}");
            Console.WriteLine($"{myBoolTrue} || {myBoolFalse} : {myBoolTrue || myBoolFalse}");
            Console.WriteLine($"!{myBoolTrue} : {!myBoolTrue}");
            Console.WriteLine($"!{myBoolFalse} : {!myBoolFalse}");
            /// Bitwise operators.
            Console.WriteLine($"{Convert.ToString(myByteA, 2)} & {Convert.ToString(myByteB, 2)} : {Convert.ToString(myByteA & myByteB, 2)}");
            Console.WriteLine($"{Convert.ToString(myByteA, 2)} | {Convert.ToString(myByteB, 2)} : {Convert.ToString(myByteA | myByteB, 2)}");
            Console.WriteLine($"{Convert.ToString(myByteA, 2)} ^ {Convert.ToString(myByteB, 2)} : {Convert.ToString(myByteA ^ myByteB, 2)}");
            Console.WriteLine($"~{Convert.ToString(myByteA)} : {Convert.ToString(~myByteA, 2)}");
            Console.WriteLine($"~{Convert.ToString(myByteB)} : {Convert.ToString(~myByteB, 2)}");
            Console.WriteLine($"{Convert.ToString(myByteA, 2)} << 4 : {Convert.ToString(myByteA << 4, 2)}");
            Console.WriteLine($"{Convert.ToString(myByteA, 2)} >> 4 : {Convert.ToString(myByteA >> 4, 2)}");
            Console.WriteLine($"{Convert.ToString(myByteB, 2)} << 4 : {Convert.ToString(myByteB << 4, 2)}");
            Console.WriteLine($"{Convert.ToString(myByteB, 2)} >> 4 : {Convert.ToString(myByteB >> 4, 10)}");
            /// Miscellaneous opreators.
            Console.WriteLine($"sizeof(decimal): {sizeof(decimal)}");
            Console.WriteLine($"typeof(Console) : {typeof(Console)}");
            unsafe
            {
                Console.WriteLine($"Address of myByteA: {(long)(&myByteA):X}");
                sbyte* myBytePointer = &myByteB;
                Console.WriteLine($"Value of myByteB: {*myBytePointer}");
            }
            Console.WriteLine($"true ? false : true : {(true ? false : true)}");
            object myObject = "something";
            Console.WriteLine($"myObject is string : {myObject is string}");
            Console.WriteLine($"myObject as string : {myObject as string}");
        }
    }
}