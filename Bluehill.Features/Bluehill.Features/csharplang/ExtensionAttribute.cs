#if !NET35_OR_GREATER && !NETSTANDARD1_0_OR_GREATER && !NETCOREAPP1_0_OR_GREATER
namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Assembly)]
internal sealed class ExtensionAttribute : Attribute { }
#endif