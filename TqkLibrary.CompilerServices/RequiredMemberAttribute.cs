#if !NET6_0_OR_GREATER
#pragma warning disable
namespace System.Runtime.CompilerServices
{
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    internal sealed class RequiredMemberAttribute : System.Attribute
    {
    }
}
#pragma warning enable
#endif