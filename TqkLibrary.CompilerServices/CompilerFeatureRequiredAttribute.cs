#if !NET6_0_OR_GREATER
#pragma warning disable
namespace System.Runtime.CompilerServices
{
    [System.AttributeUsage(System.AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    internal sealed class CompilerFeatureRequiredAttribute : System.Attribute
    {
        public CompilerFeatureRequiredAttribute(string featureName) => FeatureName = featureName;
        public string FeatureName { get; }
    }
}
#pragma warning enable
#endif