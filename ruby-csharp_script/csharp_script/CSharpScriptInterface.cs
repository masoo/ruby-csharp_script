using System;
using System.Runtime.InteropServices;

namespace ruby.csharp_script
{
    [Guid("0DF69598-0477-4865-9133-69EBBB8EB1C3")]
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface CSharpScriptInterface
    {
        [DispId(1)]
        object Create(string code);

        [DispId(2)]
        object RunAsync(string code);

        [DispId(3)]
        object EvaluateAsync(string code);
    }
}
