
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The provenance signal type. Always `c2pa`.<br/>
    /// Default Value: c2pa
    /// </summary>
    public enum C2PAProvenanceResultType
    {
        /// <summary>
        /// 
        /// </summary>
        C2pa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class C2PAProvenanceResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this C2PAProvenanceResultType value)
        {
            return value switch
            {
                C2PAProvenanceResultType.C2pa => "c2pa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static C2PAProvenanceResultType? ToEnum(string value)
        {
            return value switch
            {
                "c2pa" => C2PAProvenanceResultType.C2pa,
                _ => null,
            };
        }
    }
}