
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum AutoCodeInterpreterToolParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoCodeInterpreterToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoCodeInterpreterToolParamType value)
        {
            return value switch
            {
                AutoCodeInterpreterToolParamType.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoCodeInterpreterToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => AutoCodeInterpreterToolParamType.Auto,
                _ => null,
            };
        }
    }
}