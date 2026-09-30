
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Use `digest` for SIP Digest authentication. Handles 401 and 407 challenges.
    /// </summary>
    public enum LiveSIPTrunkAuthType
    {
        /// <summary>
        ///
        /// </summary>
        Digest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSIPTrunkAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSIPTrunkAuthType value)
        {
            return value switch
            {
                LiveSIPTrunkAuthType.Digest => "digest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSIPTrunkAuthType? ToEnum(string value)
        {
            return value switch
            {
                "digest" => LiveSIPTrunkAuthType.Digest,
                _ => null,
            };
        }
    }
}