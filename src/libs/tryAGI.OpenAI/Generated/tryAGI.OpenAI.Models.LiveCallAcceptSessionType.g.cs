
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The session type. Always `live`.<br/>
    /// Default Value: live
    /// </summary>
    public enum LiveCallAcceptSessionType
    {
        /// <summary>
        ///
        /// </summary>
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveCallAcceptSessionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveCallAcceptSessionType value)
        {
            return value switch
            {
                LiveCallAcceptSessionType.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveCallAcceptSessionType? ToEnum(string value)
        {
            return value switch
            {
                "live" => LiveCallAcceptSessionType.Live,
                _ => null,
            };
        }
    }
}