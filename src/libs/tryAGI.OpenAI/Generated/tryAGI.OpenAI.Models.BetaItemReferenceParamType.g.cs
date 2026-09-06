
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of item to reference. Always `item_reference`.<br/>
    /// Default Value: item_reference
    /// </summary>
    public enum BetaItemReferenceParamType
    {
        /// <summary>
        ///
        /// </summary>
        ItemReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaItemReferenceParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaItemReferenceParamType value)
        {
            return value switch
            {
                BetaItemReferenceParamType.ItemReference => "item_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaItemReferenceParamType? ToEnum(string value)
        {
            return value switch
            {
                "item_reference" => BetaItemReferenceParamType.ItemReference,
                _ => null,
            };
        }
    }
}