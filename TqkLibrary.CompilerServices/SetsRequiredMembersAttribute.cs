#if !NET7_0_OR_GREATER
#pragma warning disable
namespace System.Diagnostics.CodeAnalysis
{
    [System.AttributeUsage(System.AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
    internal sealed class SetsRequiredMembersAttribute : System.Attribute
    {
    }
}
#pragma warning enable
#endif