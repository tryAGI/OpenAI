
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ProvenanceResourceResultDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        C2pa,
        /// <summary>
        ///
        /// </summary>
        Synthid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProvenanceResourceResultDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProvenanceResourceResultDiscriminatorType value)
        {
            return value switch
            {
                ProvenanceResourceResultDiscriminatorType.C2pa => "c2pa",
                ProvenanceResourceResultDiscriminatorType.Synthid => "synthid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProvenanceResourceResultDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "c2pa" => ProvenanceResourceResultDiscriminatorType.C2pa,
                "synthid" => ProvenanceResourceResultDiscriminatorType.Synthid,
                _ => null,
            };
        }
    }
}