using System;
using System.Runtime.Remoting.Messaging;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {

            /*
             * this for Try & catch & finally 
             */
            //string nonNullOperation =  operation ?? throw new ArgumentNullException(nameof(operation));
            ////if (operation is null)
            ////{
            ////    throw new ArgumentNullException(nameof(operation));
            ////}
            //if (nonNullOperation == "/")
            //{
            //    return Divide(number1, number2);
            //}
            //else
            //{
            //    throw new ArgumentOutOfRangeException(nameof(operation),"The mathematical operator is not supported.");
            //    //Console.WriteLine("Unknown operation.");
            //    //return 0;
            //}


            //RETHROWING EXCEPTIONS
            //string nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));
            //if (nonNullOperation == "/")
            //{
            //    try
            //    {
            //        return Divide(number1, number2);
            //    }
            //    catch(DivideByZeroException ex )
            //    {
            //        //Log.Error(ex);
            //        throw;
            //    }
            //}
            //else
            //{
            //    throw new ArgumentOutOfRangeException(nameof(operation), "The mathematical operator is not supported.");
            //}


            // WRAPPING EXCEPTIONS means wraaping a small exception in a bigger one ArithmeticException will wrap DividedByZeroException
            //string nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));
            //if (nonNullOperation == "/")
            //{
            //    try
            //    {
            //        return Divide(number1, number2);
            //    }
            //    catch (DivideByZeroException ex)
            //    {
            //        //Our general catch block executes with Sorry, something went wrong, but this time the type of the exception is ArithmeticException; 
            //        //however, notice as before, we've lost valuable stack trace information, 
            //        //and once again we're losing the fact that the original exception occurred inside the Divide method. 
            //        //So let's hit Enter to exit, and we'll go and fix this up. Recall earlier in the course when we discussed the System. 
            //        //Exception type, we learned about a number of different constructors. 
            //        //One of these constructors takes a message and also allows us to specify an innerException. 
            //        //So let's modify this ArithmeticException constructor. We'll start off by providing a message,
            //        //so we'll just say that an error occurred during calculation, and as a second parameter here, we can specify an innerException. 
            //        throw new ArithmeticException("An error occured during calculations", ex);
            //    }
            //}
            //else
            //{
            //    throw new ArgumentOutOfRangeException(nameof(operation), "The mathematical operator is not supported.");
            //}

            // FILTERING CATCHES 
            string nonNullOperation = operation ?? throw new ArgumentNullException(nameof(number1));
            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch (DivideByZeroException ex)
                {
                    throw new ArithmeticException("An error occured during calculations", ex);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(operation), "The mathematical operator is not supported.");
            }


        }

        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}

