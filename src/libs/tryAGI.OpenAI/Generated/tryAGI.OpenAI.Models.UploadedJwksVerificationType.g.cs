
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: uploaded_jwks
    /// </summary>
    public enum UploadedJwksVerificationType
    {
        /// <summary>
        ///
        /// </summary>
        UploadedJwks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadedJwksVerificationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadedJwksVerificationType value)
        {
            return value switch
            {
                UploadedJwksVerificationType.UploadedJwks => "uploaded_jwks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadedJwksVerificationType? ToEnum(string value)
        {
            return value switch
            {
                "uploaded_jwks" => UploadedJwksVerificationType.UploadedJwks,
                _ => null,
            };
        }
    }
}