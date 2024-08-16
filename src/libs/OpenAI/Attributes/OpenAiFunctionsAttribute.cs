// ReSharper disable once CheckNamespace
namespace OpenAI;

/// <summary>
/// 
/// </summary>
[AttributeUsage(AttributeTargets.Interface)]
[System.Diagnostics.Conditional("OPENAI_TOOLS_ATTRIBUTES")]
public sealed class OpenAiToolsAttribute : Attribute
{
    /// <summary>
    /// 
    /// </summary>
    public bool Strict { get; set; }
}