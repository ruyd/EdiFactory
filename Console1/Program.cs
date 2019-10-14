using System;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {



            var ass = System.Reflection.Assembly.GetAssembly(typeof(OopFactory.X12.Parsing.X12Parser)); 
            var list = ass.GetManifestResourceNames();



        }
    }
}
