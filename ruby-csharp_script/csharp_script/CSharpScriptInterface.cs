using System;
using System.Runtime.InteropServices;

namespace ruby.csharp_script
{
    [Guid("0DF69598-0477-4865-9133-69EBBB8EB1C3")]
    public interface CSharpScriptInterface
    {
        [return: MarshalAs(UnmanagedType.Interface)]
        object Create(string code);

        [return: MarshalAs(UnmanagedType.Interface)]
        object RunAsync(string code);

        [return: MarshalAs(UnmanagedType.Interface)]
        object EvaluateAsync(string code);
    }
}
