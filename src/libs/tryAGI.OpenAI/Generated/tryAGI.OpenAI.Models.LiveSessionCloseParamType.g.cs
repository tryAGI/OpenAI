
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The Live client event type. Always `session.close`.<br/>
    /// Default Value: session.close
    /// </summary>
    public enum LiveSessionCloseParamType
    {
        /// <summary>
        ///
        /// </summary>
        SessionClose,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionCloseParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionCloseParamType value)
        {
            return value switch
            {
                LiveSessionCloseParamType.SessionClose => "session.close",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionCloseParamType? ToEnum(string value)
        {
            return value switch
            {
                "session.close" => LiveSessionCloseParamType.SessionClose,
                _ => null,
            };
        }
    }
}