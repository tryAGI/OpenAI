
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: uploaded_jwks
    /// </summary>
    public enum UploadedJwksVerificationParamType
    {
        /// <summary>
        ///
        /// </summary>
        UploadedJwks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadedJwksVerificationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadedJwksVerificationParamType value)
        {
            return value switch
            {
                UploadedJwksVerificationParamType.UploadedJwks => "uploaded_jwks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadedJwksVerificationParamType? ToEnum(string value)
        {
            return value switch
            {
                "uploaded_jwks" => UploadedJwksVerificationParamType.UploadedJwks,
                _ => null,
            };
        }
    }
}