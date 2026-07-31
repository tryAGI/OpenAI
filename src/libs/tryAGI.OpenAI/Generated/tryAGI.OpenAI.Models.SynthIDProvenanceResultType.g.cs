
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The provenance signal type. Always `synthid`.<br/>
    /// Default Value: synthid
    /// </summary>
    public enum SynthIDProvenanceResultType
    {
        /// <summary>
        /// 
        /// </summary>
        Synthid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SynthIDProvenanceResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SynthIDProvenanceResultType value)
        {
            return value switch
            {
                SynthIDProvenanceResultType.Synthid => "synthid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SynthIDProvenanceResultType? ToEnum(string value)
        {
            return value switch
            {
                "synthid" => SynthIDProvenanceResultType.Synthid,
                _ => null,
            };
        }
    }
}