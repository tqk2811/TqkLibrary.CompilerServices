#if !NET5_0_OR_GREATER
#pragma warning disable
using System.ComponentModel;
namespace System.Runtime.CompilerServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static class IsExternalInit { }
}
#pragma warning enable
#endif