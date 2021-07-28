
using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            // var calculator = new Calculator();
            // var result = calculator.Divice(5, 0); //!Exception since cannot divide by 0

            //?stack trace shows the sequence of methods that were called until the exception was thrown

            //!----
            //*to handle exceptions
            // try
            // {
            //     var calculator = new Calculator();
            //     var result = calculator.Divide(5, 0);
            // }
            // catch(DivideByZeroException ex)
            // {
            //     Console.WriteLine("You cannot divide by 0");
            // }
            // catch(Exception ex)
            // {    
            //      //* can display message or can rethrow error
            //     Console.WriteLine("An unexpected error occured");
            // }

            //!----
            // StreamReader streamReader = null;
            // try{
            //     streamReader = new StreamReader("path");
            //     var content = streamReader.ReadToEnd();
            //     throw new Exception("Oops");
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine("An error occured");
            // }
            // finally
            // {
            //     //? unmanaged resources e.g. file handles, db connections, network connections,
            //     //? graphic handles are not managed by CLR (no garbage collections is applied to them)
            //     //? need to manually do the cleanup -> IDisposable
            //     if (streamReader != null)
            //     {
            //         streamReader.Dispose();
            //     }
            // }

            //!----
            // //? With using statement, a finally block is created under the hood -> no manual dispose
            // try
            // {
            //     using (var streamReader = new StreamReader("path"))
            //     {
            //         var content = streamReader.ReadToEnd();
            //     }
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine("An error occured");
            // }


            //!----
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("boo");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
