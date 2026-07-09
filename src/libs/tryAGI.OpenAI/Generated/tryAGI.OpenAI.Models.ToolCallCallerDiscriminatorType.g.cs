
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolCallCallerDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        Program,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallCallerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallCallerDiscriminatorType value)
        {
            return value switch
            {
                ToolCallCallerDiscriminatorType.Direct => "direct",
                ToolCallCallerDiscriminatorType.Program => "program",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallCallerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "direct" => ToolCallCallerDiscriminatorType.Direct,
                "program" => ToolCallCallerDiscriminatorType.Program,
                _ => null,
            };
        }
    }
}