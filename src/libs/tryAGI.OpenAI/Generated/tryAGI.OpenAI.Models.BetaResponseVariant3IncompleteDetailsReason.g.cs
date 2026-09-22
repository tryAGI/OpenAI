
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The reason why the response is incomplete. `steered` means<br/>
    /// the response stopped at a safe output boundary after a<br/>
    /// WebSocket `response.steer` event. The server can then create<br/>
    /// a successor response automatically with the queued input.
    /// </summary>
    public enum BetaResponseVariant3IncompleteDetailsReason
    {
        /// <summary>
        ///
        /// </summary>
        ContentFilter,
        /// <summary>
        ///
        /// </summary>
        MaxMessages,
        /// <summary>
        ///
        /// </summary>
        MaxOutputTokens,
        /// <summary>
        ///
        /// </summary>
        Steered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseVariant3IncompleteDetailsReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseVariant3IncompleteDetailsReason value)
        {
            return value switch
            {
                BetaResponseVariant3IncompleteDetailsReason.ContentFilter => "content_filter",
                BetaResponseVariant3IncompleteDetailsReason.MaxMessages => "max_messages",
                BetaResponseVariant3IncompleteDetailsReason.MaxOutputTokens => "max_output_tokens",
                BetaResponseVariant3IncompleteDetailsReason.Steered => "steered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseVariant3IncompleteDetailsReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => BetaResponseVariant3IncompleteDetailsReason.ContentFilter,
                "max_messages" => BetaResponseVariant3IncompleteDetailsReason.MaxMessages,
                "max_output_tokens" => BetaResponseVariant3IncompleteDetailsReason.MaxOutputTokens,
                "steered" => BetaResponseVariant3IncompleteDetailsReason.Steered,
                _ => null,
            };
        }
    }
}