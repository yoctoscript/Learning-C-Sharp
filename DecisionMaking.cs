using System;

namespace MyDecisionMaking
{
    internal class DecisionMaking
    {
        public static void Entry()
        {
            /// If statement.
            int myInt1 = 777;
            if (myInt1 > 0)
            {
                Console.WriteLine($"myInt1 > 0 : {myInt1}");
                if (myInt1 > 500)
                {
                    Console.WriteLine($"myInt1 > 500");
                }
            }
            else if (myInt1 == 0)
            {
                Console.WriteLine($"myInt1 == 0 : {myInt1}");
            }
            else
            {
                Console.WriteLine($"myInt1 < 0 : {myInt1}");
            }
            Console.WriteLine("------------------------------------------");
            /// Switch statement.
            /// Control falls through from one case label to another as long as the previous case has no body.
            object myObject = "halo";
            bool myBool = true;
            Range range = 0..5;
            /// Switch statements with pattern matching allow you to match a switch expression against a pattern, which can be a range of values, types, and structures.
            switch (myObject)
            {
                case byte myByte:
                case short myShort when myShort == short.MaxValue:
                    Console.WriteLine("Fall through in outer switch");
                    break;
                case int myInt:
                    switch (myInt)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("Fall through in inner switch");
                            if (myInt >= range.Start.Value && myInt <= range.End.Value)
                            {
                                Console.WriteLine("Value is between 0 and 5!");
                            }
                            break;
                        case 100 when myBool:
                            Console.WriteLine($"myInt : 100, myBool : true");
                            break;
                        case 100 when !myBool:
                            Console.WriteLine($"myInt : 100, myBool : false");
                            break;
                        default:
                            Console.WriteLine("Default case in inner switch");
                            break;
                        /// Control cannot fall out of switch from final case label (be it default or another case).
                    }
                    break;
                case long myLong:
                    Console.WriteLine($"myLong : {myLong}");
                    break;
                default:
                    Console.WriteLine("No pattern matched");
                    break;
            }
        }
    }
}