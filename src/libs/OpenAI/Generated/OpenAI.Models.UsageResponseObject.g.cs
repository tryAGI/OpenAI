
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        Page,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageResponseObject value)
        {
            return value switch
            {
                UsageResponseObject.Page => "page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "page" => UsageResponseObject.Page,
                _ => null,
            };
        }
    }
}