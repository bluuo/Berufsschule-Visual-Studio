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
        try
        {
            int j = 1 / zero;
        }


        //this code is handling a dividebyzeroexception. it attempts to write the exception 
        //to a file, but if that fails, it throws a new dividebyzeroexception with 
        //the original message and the inner exception as parameters. finally,
        //it closes the streamwriter if it is not null.
        catch (DivideByZeroException dbze)
        {
            StreamWriter sw = null;
            try
            {   // Exception handling schlägt fehl (* im Dateinamen)!
                sw = new StreamWriter("ungültig*txt");
                sw.Write(dbze);
            }
            catch (Exception e)
            {   // Exception erneut werfen mit Parameter innerException
                throw new DivideByZeroException(dbze.Message, e);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }
    }
}

