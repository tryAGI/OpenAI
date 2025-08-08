
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Allowed tool configuration type. Always `allowed_tools`.
    /// </summary>
    public enum ToolChoiceAllowedType
    {
        /// <summary>
        /// 
        /// </summary>
        AllowedTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceAllowedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceAllowedType value)
        {
            return value switch
            {
                ToolChoiceAllowedType.AllowedTools => "allowed_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceAllowedType? ToEnum(string value)
        {
            return value switch
            {
                "allowed_tools" => ToolChoiceAllowedType.AllowedTools,
                _ => null,
            };
        }
    }
}