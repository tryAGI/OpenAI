
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: gcp
    /// </summary>
    public enum GcpExternalKeyParamsType
    {
        /// <summary>
        ///
        /// </summary>
        Gcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GcpExternalKeyParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GcpExternalKeyParamsType value)
        {
            return value switch
            {
                GcpExternalKeyParamsType.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GcpExternalKeyParamsType? ToEnum(string value)
        {
            return value switch
            {
                "gcp" => GcpExternalKeyParamsType.Gcp,
                _ => null,
            };
        }
    }
}