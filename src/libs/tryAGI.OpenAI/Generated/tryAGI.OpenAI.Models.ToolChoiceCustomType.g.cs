
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// For custom tool calling, the type is always `custom`.
    /// </summary>
    public enum ToolChoiceCustomType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceCustomTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceCustomType value)
        {
            return value switch
            {
                ToolChoiceCustomType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceCustomType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => ToolChoiceCustomType.Custom,
                _ => null,
            };
        }
    }
}