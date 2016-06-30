using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scripting = Microsoft.CodeAnalysis.CSharp.Scripting;

namespace ruby.csharp_script
{
    /// <summary>
    /// CSharpScript wrapper.
    /// </summary>
    public static class CSharpScript
    {
        /// <summary>
        /// Create a new C# script.
        /// </summary>
        /// <param name="code">The source code of the script.</param>
        /// <returns></returns>
        public static object Create(string code)
        {
            return Scripting.CSharpScript.Create(code);
        }

        /// <summary>
        /// Run a C# script.
        /// </summary>
        /// <param name="code">The source code of the script.</param>
        /// <returns></returns>
        public static object RunAsync(string code)
        {
            return Scripting.CSharpScript.RunAsync(code);
        }

        /// <summary>
        /// Run a C# script and return its resulting value.
        /// </summary>
        /// <param name="code">The source code of the script.</param>
        /// <returns>Returns the value returned by running the script.</returns>
        public static object EvaluateAsync(string code)
        {
            return Scripting.CSharpScript.EvaluateAsync(code);
        }
    }
}
