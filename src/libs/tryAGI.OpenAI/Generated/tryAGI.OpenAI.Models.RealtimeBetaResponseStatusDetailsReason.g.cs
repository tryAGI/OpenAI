
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The reason the Response did not complete. For a `cancelled` Response, <br/>
    /// one of `turn_detected` (the server VAD detected a new start of speech) <br/>
    /// or `client_cancelled` (the client sent a cancel event). For an <br/>
    /// `incomplete` Response, one of `max_output_tokens` or `content_filter` <br/>
    /// (the server-side safety filter activated and cut off the response).
    /// </summary>
    public enum RealtimeBetaResponseStatusDetailsReason
    {
        /// <summary>
        /// 
        /// </summary>
        ClientCancelled,
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        MaxOutputTokens,
        /// <summary>
        /// 
        /// </summary>
        TurnDetected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaResponseStatusDetailsReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaResponseStatusDetailsReason value)
        {
            return value switch
            {
                RealtimeBetaResponseStatusDetailsReason.ClientCancelled => "client_cancelled",
                RealtimeBetaResponseStatusDetailsReason.ContentFilter => "content_filter",
                RealtimeBetaResponseStatusDetailsReason.MaxOutputTokens => "max_output_tokens",
                RealtimeBetaResponseStatusDetailsReason.TurnDetected => "turn_detected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaResponseStatusDetailsReason? ToEnum(string value)
        {
            return value switch
            {
                "client_cancelled" => RealtimeBetaResponseStatusDetailsReason.ClientCancelled,
                "content_filter" => RealtimeBetaResponseStatusDetailsReason.ContentFilter,
                "max_output_tokens" => RealtimeBetaResponseStatusDetailsReason.MaxOutputTokens,
                "turn_detected" => RealtimeBetaResponseStatusDetailsReason.TurnDetected,
                _ => null,
            };
        }
    }
}