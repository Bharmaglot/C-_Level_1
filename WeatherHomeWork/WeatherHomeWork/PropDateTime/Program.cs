using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace PropDateTime
{
    class Program
    {
        static void Main(string[] args)
        {

            Type type = typeof(DateTime);
            Console.WriteLine(type.GetType());
            Console.WriteLine(type.GetTypeInfo());
            Console.WriteLine(type.GUID);
            Console.WriteLine(type.GetRuntimeProperties());
            Console.WriteLine(type.GetRuntimeMethods());

            Console.ReadKey();
        }
    }
}
