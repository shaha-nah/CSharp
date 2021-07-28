
using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;

            // Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault()); //preferred
            // Console.WriteLine("HasValue: " + data.HasValue);
            // Console.WriteLine("Value" + data.Value);

            // DateTime? date = new DateTime(2014, 1, 1);
            // DateTime date2 = date.GetValueOrDefault();
            // DateTime? date3 = date2; //a value type can be converted to a nullable type
            // Console.WriteLine(date3.GetValueOrDefault());


            DateTime date2 = date ?? DateTime.Today;

            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;



            Console.WriteLine(date2);



        }
    }
}
