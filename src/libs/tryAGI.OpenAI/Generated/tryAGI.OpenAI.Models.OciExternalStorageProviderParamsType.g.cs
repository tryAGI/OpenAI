
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: oci
    /// </summary>
    public enum OciExternalStorageProviderParamsType
    {
        /// <summary>
        ///
        /// </summary>
        Oci,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OciExternalStorageProviderParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OciExternalStorageProviderParamsType value)
        {
            return value switch
            {
                OciExternalStorageProviderParamsType.Oci => "oci",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OciExternalStorageProviderParamsType? ToEnum(string value)
        {
            return value switch
            {
                "oci" => OciExternalStorageProviderParamsType.Oci,
                _ => null,
            };
        }
    }
}