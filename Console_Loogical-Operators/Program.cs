using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Loogical_Operators
{
    class Program : LogicalOperators
    {
        static void Main(string[] args)
        {
        start:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Choose from the list:(1/2) :" + "\n"
                + "1.Show individual act of a operator on two operands:" + "\n"
                 + "2.Show all possible conditions of an operator on the operands:" + "\n"
                );
            int i = int.Parse(Console.ReadLine());
            if (i == 1)
            {                
                MyMethod();
                goto start;
            }
            else if (i == 2)
            {
                MyMethod2();
                goto start;
            }
        }
    }


    public class LogicalOperators
    {
        public static void MyMethod()
        {
            bool Continue = true;
            Console.ResetColor();
            Console.Clear();
            while (Continue is true)
            {


                Console.Write("Please Enter your 1st Operand (True/False):");
                bool a = Convert.ToBoolean(Console.ReadLine());

                Console.Write("Please Enter your 2th Operand (True/False):");
                bool b = Convert.ToBoolean(Console.ReadLine());

                Console.Write("Please Enter your Operator:");
                string Operator = Console.ReadLine();

                switch (LogicalOperatos(a, b, Operator))
                {
                    case true:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The Result is True");
                        Console.ResetColor();

                        break;
                    case false:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The Result is False");
                        Console.ResetColor();
                        break;
                }

                Console.Write("Are you continue?(Y/N):");
                if (((Console.ReadLine()).ToUpper() == "Y"))
                    Continue = true;
                else
                    Continue = false;

            }
        }
        public static void MyMethod2()
        {
            bool Continue = true;
            Console.ResetColor();
            Console.Clear();
            while (Continue is true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                string msg = @"Which Operator?" + "\n" + "! NOT operator " +
                                                  "\n" + "| Logical OR operator " +
                                                  "\n" + "& logical AND operator " +
                                                  "\n" + "^ Logical exclusive OR operator (XOR)" +                                                  
                                                  "\n" + "???";
                Console.WriteLine(msg);
                string Operator = Console.ReadLine();
                Console.ResetColor();
                switch (Operator.ToUpper())
                {
                    case "NOT":
                        Console.WriteLine("NOT True: {0}", !true);
                        Console.WriteLine("NOT False: {0}", !false);
                        Console.ReadKey();
                        break;
                    case "OR":
                        Console.WriteLine("True OR True: {0}", true | true);
                        Console.WriteLine("False OR False: {0}", false | false);
                        Console.WriteLine("True OR False: {0}", true | false);
                        Console.WriteLine("False OR True: {0}", false | true);
                        Console.ReadKey();
                        break;
                    case "XOR":
                        Console.WriteLine("True XOR True: {0}", true ^ true);
                        Console.WriteLine("False XOR False: {0}", false ^ false);
                        Console.WriteLine("True XOR False: {0}", true ^ false);
                        Console.WriteLine("False XOR True: {0}", false ^ true);
                        Console.ReadKey();
                        break;
                    case "AND":
                        Console.WriteLine("True AND True: {0}", true & true);
                        Console.WriteLine("False AND False: {0}", false & false);
                        Console.WriteLine("True AND False: {0}", true & false);
                        Console.WriteLine("False AND True: {0}", false & true);
                        Console.ReadKey();
                        break;
                }
                Console.Write("Are you continue?(Y/N):");
                if (((Console.ReadLine()).ToUpper() == "Y"))
                    Continue = true;
                else
                    Continue = false;
            }
        }
        static bool LogicalOperatos(bool a, bool b, string Operator)
        {
            switch (Operator.ToUpper())
            {
                case "NOT":
                    return (!a);
                    break;
                case "OR":
                    return (a | b);
                    break;
                case "AND":
                    return (a & b);
                    break;
                case "XOR":
                    return (a ^ b);
                    break;
            }
            return false;
        }
    }

}
