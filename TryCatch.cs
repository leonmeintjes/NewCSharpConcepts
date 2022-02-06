using System;

namespace NewCSharpConcepts
{
    public class TryCatch
    {
        public void Work()
        {
            Console.WriteLine("Open File");
            try
            {
                Console.WriteLine("Throwing an exception");
                throw new SystemException();

            }
            catch (Exception)
            {
                Console.WriteLine("Handling the exception...");

            }
            finally
            {
                Console.WriteLine("Closing file...");
            }
        }
    }
}