
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ExternalKeyPurpose
    {
        /// <summary>
        ///
        /// </summary>
        Ekm,
        /// <summary>
        ///
        /// </summary>
        PspDecryption,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalKeyPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalKeyPurpose value)
        {
            return value switch
            {
                ExternalKeyPurpose.Ekm => "ekm",
                ExternalKeyPurpose.PspDecryption => "psp_decryption",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalKeyPurpose? ToEnum(string value)
        {
            return value switch
            {
                "ekm" => ExternalKeyPurpose.Ekm,
                "psp_decryption" => ExternalKeyPurpose.PspDecryption,
                _ => null,
            };
        }
    }
}