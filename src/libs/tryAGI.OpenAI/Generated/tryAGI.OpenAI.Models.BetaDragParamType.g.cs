
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a drag action, this property is always set to `drag`.<br/>
    /// Default Value: drag
    /// </summary>
    public enum BetaDragParamType
    {
        /// <summary>
        ///
        /// </summary>
        Drag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaDragParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDragParamType value)
        {
            return value switch
            {
                BetaDragParamType.Drag => "drag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDragParamType? ToEnum(string value)
        {
            return value switch
            {
                "drag" => BetaDragParamType.Drag,
                _ => null,
            };
        }
    }
}