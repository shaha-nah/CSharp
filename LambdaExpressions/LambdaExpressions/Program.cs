
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //args => expression

            //() => ...
            //x => ...
            //(x,y, z) => ...

            //Func<int, int> : delegate
            // Func<int, int> square = number => number * number;
            // Console.WriteLine(square(5));

            //method that takes a number and multiplies that by its factor
            // const int factor = 5;
            // Func<int, int> mutiplier = n => n * factor;
            // var result = multiplier(10);
            // Console.WriteLine(result);

            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

        }
    }
}
