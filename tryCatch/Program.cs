using System;

namespace ExceptionHandling
{
    class OverflowExceptionCust : Exception
    {
        private int ErrorInt;
        public OverflowExceptionCust()
        {

        }
        public OverflowExceptionCust(string message) : base(message)
        {

        }
        public string getMessage()
        {
            return Message;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string value = "654654654564654654646546";


            try
            {
                p.function1(value);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowExceptionCust e)
            {

                Console.WriteLine(e.getMessage());

            }
        }

        private void function1(string input)
        {
            function2(input);
        }

        private void function2(string input)
        {
            function3(input);
        }

        private void function3(string input)
        {
            try
            {
                int Zahl = Convert.ToInt32(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("LOWEST FormatError");
            }
            catch (OverflowException)
            {
                Console.WriteLine("LOWEST OverflowError");
                throw new OverflowExceptionCust("ExceptionMessage: Der String ist zu lang!!");
            }
            finally
            {
                Console.WriteLine("FINALLY");
            }
        }
    }
}
