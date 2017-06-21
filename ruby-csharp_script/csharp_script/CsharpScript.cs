using System;
using System.Runtime.InteropServices;
using Scripting = Microsoft.CodeAnalysis.CSharp.Scripting;

namespace ruby.csharp_script
{
    /// <summary>
    /// CSharpScript wrapper.
    /// </summary>
    [Guid("31D3AA19-291D-449C-9B2B-E02B9D6F766C")]
    [ComVisible(true)]
    [ProgId("ruby.csharp_script.CSharpScript")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComDefaultInterface(typeof(CSharpScriptInterface))]
    [ComSourceInterfaces(typeof(CSharpScriptEvents))]
    public class CSharpScript : CSharpScriptInterface
    {
        /// <summary>
        /// Create a new C# script.
        /// </summary>
        /// <param name="code">The source code of the script.</param>
        /// <returns></returns>
        public object Create(string code)
        {
            return Scripting.CSharpScript.Create(code);
        }

        /// <summary>
        /// Run a C# script.
        /// </summary>
        /// <param name="code">The source code of the script.</param>
        /// <returns></returns>
        public object RunAsync(string code)
        {
            return Scripting.CSharpScript.RunAsync(code).Result;
        }

        /// <summary>
        /// Run a C# script and return its resulting value.
        /// </summary>
        /// <param name="code">The source code of the script.</param>
        /// <returns>Returns the value returned by running the script.</returns>
        public object EvaluateAsync(string code)
        {
            return Scripting.CSharpScript.EvaluateAsync(code).Result;
        }
    }
}
