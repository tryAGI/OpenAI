
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RankerVersionType
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Default20241115,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RankerVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RankerVersionType value)
        {
            return value switch
            {
                RankerVersionType.Auto => "auto",
                RankerVersionType.Default20241115 => "default-2024-11-15",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RankerVersionType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RankerVersionType.Auto,
                "default-2024-11-15" => RankerVersionType.Default20241115,
                _ => null,
            };
        }
    }
}