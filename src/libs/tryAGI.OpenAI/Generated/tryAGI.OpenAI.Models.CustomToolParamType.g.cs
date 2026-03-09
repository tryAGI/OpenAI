
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the custom tool. Always `custom`.<br/>
    /// Default Value: custom
    /// </summary>
    public enum CustomToolParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolParamType value)
        {
            return value switch
            {
                CustomToolParamType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CustomToolParamType.Custom,
                _ => null,
            };
        }
    }
}