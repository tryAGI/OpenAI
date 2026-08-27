
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a type action, this property is always set to `type`.<br/>
    /// Default Value: type
    /// </summary>
    public enum BetaTypeParamType
    {
        /// <summary>
        ///
        /// </summary>
        Type,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTypeParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTypeParamType value)
        {
            return value switch
            {
                BetaTypeParamType.Type => "type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTypeParamType? ToEnum(string value)
        {
            return value switch
            {
                "type" => BetaTypeParamType.Type,
                _ => null,
            };
        }
    }
}