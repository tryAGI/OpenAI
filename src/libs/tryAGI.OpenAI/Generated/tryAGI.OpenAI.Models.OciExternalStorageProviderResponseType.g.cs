
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: oci
    /// </summary>
    public enum OciExternalStorageProviderResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Oci,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OciExternalStorageProviderResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OciExternalStorageProviderResponseType value)
        {
            return value switch
            {
                OciExternalStorageProviderResponseType.Oci => "oci",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OciExternalStorageProviderResponseType? ToEnum(string value)
        {
            return value switch
            {
                "oci" => OciExternalStorageProviderResponseType.Oci,
                _ => null,
            };
        }
    }
}