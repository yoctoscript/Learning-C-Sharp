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
            object myObject = (string)"0.2";
            switch (myObject)
            {
                case byte myByte:
                case short myShort:
                case int myInt:
                    Console.WriteLine("[case byte] Fell out");
                    Console.WriteLine("[case short] Fell out");
                    Console.WriteLine($"[case int] Breaking");
                    break;
                /// Range-based case.
                case long myLong when myLong >= 0 && myLong <= 100:
                    Console.WriteLine($"[case long][>= 0 && <= 100] myLong: {myLong}");
                    break;
                case long myLong:
                    Console.WriteLine($"[case long][< 0 && > 100] myLong: {myLong}");
                    break;
                /// Type-based case.
                case decimal myDecimal:
                    switch (myDecimal)
                    {
                        /// Value-based case.
                        case 10.2m:
                            Console.WriteLine($"[case 10.2m] myDecimal: {myDecimal}");
                            break;
                        /// Comparison case.
                        case > 20.0m:
                            Console.WriteLine($"[case > 20.0] myDecimal: {myDecimal}");
                            break;
                        /// When clause.
                        case 0 when 9 < 11:
                            Console.WriteLine($"[case 0 when 9 > 11] myDecimal: {myDecimal}");
                            break;
                        /// Control cannot fall out of final case label (be it default or another case).
                        default:
                            Console.WriteLine($"[default] myDecimal: {myDecimal}");
                            break;
                    }
                    break;
                /// Control cannot fall out of final case label (be it default or another case).
                case object:
                    Console.WriteLine("[default] Unknown type");
                    break;
            }
        }
    }
}