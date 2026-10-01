
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The voice creation method. Defaults to `consent` when omitted.<br/>
    /// Default Value: consent
    /// </summary>
    public enum CreateVoiceFromConsentRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Consent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVoiceFromConsentRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoiceFromConsentRequestType value)
        {
            return value switch
            {
                CreateVoiceFromConsentRequestType.Consent => "consent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVoiceFromConsentRequestType? ToEnum(string value)
        {
            return value switch
            {
                "consent" => CreateVoiceFromConsentRequestType.Consent,
                _ => null,
            };
        }
    }
}