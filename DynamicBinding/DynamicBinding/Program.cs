
using System.Threading;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Reflection is a way to inspect the metadata about the type
            object obj = "boo";
            // obj.GetHashCode();
            
            //* with reflection
            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

            //* with dynamic
            dynamic excelObject = "dummy";
            excelObject.Optimize();

            //* can change types -- no explicit casting
            dynamic name = "boo";
            // name = 10;
            // name++; //!exception since we cannot do that with a string

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b; //*c will become dynamic

            int i = 5;
            dynamic d = i;
            long l = d;


        }
    }
}
