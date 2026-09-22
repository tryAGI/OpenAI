
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: call_error
    /// </summary>
    public enum LiveTransportCallErrorType
    {
        /// <summary>
        ///
        /// </summary>
        CallError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveTransportCallErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveTransportCallErrorType value)
        {
            return value switch
            {
                LiveTransportCallErrorType.CallError => "call_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveTransportCallErrorType? ToEnum(string value)
        {
            return value switch
            {
                "call_error" => LiveTransportCallErrorType.CallError,
                _ => null,
            };
        }
    }
}