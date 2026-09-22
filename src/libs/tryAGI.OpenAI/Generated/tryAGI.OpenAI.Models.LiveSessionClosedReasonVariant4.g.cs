
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: remote_hangup
    /// </summary>
    public enum LiveSessionClosedReasonVariant4
    {
        /// <summary>
        ///
        /// </summary>
        RemoteHangup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionClosedReasonVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionClosedReasonVariant4 value)
        {
            return value switch
            {
                LiveSessionClosedReasonVariant4.RemoteHangup => "remote_hangup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionClosedReasonVariant4? ToEnum(string value)
        {
            return value switch
            {
                "remote_hangup" => LiveSessionClosedReasonVariant4.RemoteHangup,
                _ => null,
            };
        }
    }
}