namespace OpenAI;

/// <summary>
/// 
/// </summary>
[AttributeUsage(AttributeTargets.Interface)]
[System.Diagnostics.Conditional("OPENAI_FUNCTIONS_ATTRIBUTES")]
public sealed class OpenAiFunctionsAttribute : Attribute;