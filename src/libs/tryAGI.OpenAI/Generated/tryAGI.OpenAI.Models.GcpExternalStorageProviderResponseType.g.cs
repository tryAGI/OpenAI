
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: gcp
    /// </summary>
    public enum GcpExternalStorageProviderResponseType
    {
        /// <summary>
        ///
        /// </summary>
        Gcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GcpExternalStorageProviderResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GcpExternalStorageProviderResponseType value)
        {
            return value switch
            {
                GcpExternalStorageProviderResponseType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GcpExternalStorageProviderResponseType? ToEnum(string value)
        {
            return value switch
            {
                "gcp" => GcpExternalStorageProviderResponseType.Gcp,
                _ => null,
            };
        }
    }
}