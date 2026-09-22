
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The Live client event type. Always `session.update`.<br/>
    /// Default Value: session.update
    /// </summary>
    public enum LiveSessionUpdateParamType
    {
        /// <summary>
        ///
        /// </summary>
        SessionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionUpdateParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionUpdateParamType value)
        {
            return value switch
            {
                LiveSessionUpdateParamType.SessionUpdate => "session.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionUpdateParamType? ToEnum(string value)
        {
            return value switch
            {
                "session.update" => LiveSessionUpdateParamType.SessionUpdate,
                _ => null,
            };
        }
    }
}