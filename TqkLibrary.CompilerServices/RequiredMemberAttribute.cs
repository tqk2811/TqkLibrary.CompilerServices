#if !NET6_0_OR_GREATER
#pragma warning disable
namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    internal sealed class RequiredMemberAttribute : Attribute { }
}
#pragma warning enable
#endif