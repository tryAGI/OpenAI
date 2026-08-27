
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of response format being defined. Always `json_object`.
    /// </summary>
    public enum BetaResponseFormatJsonObjectType
    {
        /// <summary>
        ///
        /// </summary>
        JsonObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseFormatJsonObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseFormatJsonObjectType value)
        {
            return value switch
            {
                BetaResponseFormatJsonObjectType.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseFormatJsonObjectType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => BetaResponseFormatJsonObjectType.JsonObject,
                _ => null,
            };
        }
    }
}