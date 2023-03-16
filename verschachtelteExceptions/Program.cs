using System;
using System.IO;

class Test
{
    public static void Main()
    {
        try
        {
            Division div = new Division();
        }
        catch (Exception e)
        {    // alle Exceptions mit beliebiger Verschachtelungstiefe ausgeben
            Exception currentEx = e;
            while (currentEx != null)
            {
                Console.WriteLine(currentEx.Message);
                currentEx = currentEx.InnerException;
            }
        }
        Console.ReadKey();
    }
}
class Division
{
    static int zero = 0;
    public Division()
    {


        //Try to divide by zero
        try
        {
            int j = 1 / zero;
        }
        //Catch the DivideByZeroException
        catch (DivideByZeroException dbze)
        {
            //Create a StreamWriter object
            StreamWriter sw = null;
            try
            {
                //Create a file with an invalid name
                sw = new StreamWriter("ungültig*txt");
                //Write the exception to the file
                sw.Write(dbze);
            }
            //Catch any other exceptions
            catch (Exception e)
            {
                //Throw a new DivideByZeroException with the innerException parameter
                throw new DivideByZeroException(dbze.Message, e);
            }
            //Close the StreamWriter object
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }
    }
}

