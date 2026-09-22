
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: gcp
    /// </summary>
    public enum GcpExternalStorageProviderParamsType
    {
        /// <summary>
        ///
        /// </summary>
        Gcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GcpExternalStorageProviderParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GcpExternalStorageProviderParamsType value)
        {
            return value switch
            {
                GcpExternalStorageProviderParamsType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GcpExternalStorageProviderParamsType? ToEnum(string value)
        {
            return value switch
            {
                "gcp" => GcpExternalStorageProviderParamsType.Gcp,
                _ => null,
            };
        }
    }
}