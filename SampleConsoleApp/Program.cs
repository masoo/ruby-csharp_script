using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ruby.csharp_script;

namespace SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var csharp_script = new CSharpScript();
            var result = csharp_script.EvaluateAsync("1+1");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
