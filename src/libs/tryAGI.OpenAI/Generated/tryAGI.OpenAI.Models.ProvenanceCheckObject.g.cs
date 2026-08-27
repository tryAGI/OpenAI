
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ProvenanceCheckObject
    {
        /// <summary>
        ///
        /// </summary>
        ContentProvenanceCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProvenanceCheckObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProvenanceCheckObject value)
        {
            return value switch
            {
                ProvenanceCheckObject.ContentProvenanceCheck => "content_provenance_check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProvenanceCheckObject? ToEnum(string value)
        {
            return value switch
            {
                "content_provenance_check" => ProvenanceCheckObject.ContentProvenanceCheck,
                _ => null,
            };
        }
    }
}