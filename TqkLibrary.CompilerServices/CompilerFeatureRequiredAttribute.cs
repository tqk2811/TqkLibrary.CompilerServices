#if !NET6_0_OR_GREATER
#pragma warning disable
using System;
namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    internal sealed class CompilerFeatureRequiredAttribute : Attribute
    {
        public CompilerFeatureRequiredAttribute(string featureName) => FeatureName = featureName;
        public string FeatureName { get; }
    }
}
#pragma warning enable
#endif