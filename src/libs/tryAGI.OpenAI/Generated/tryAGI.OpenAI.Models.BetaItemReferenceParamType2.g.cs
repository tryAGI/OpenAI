
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of item to reference. Always `item_reference`.<br/>
    /// Default Value: item_reference
    /// </summary>
    public enum BetaItemReferenceParamType2
    {
        /// <summary>
        /// 
        /// </summary>
        ItemReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaItemReferenceParamType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaItemReferenceParamType2 value)
        {
            return value switch
            {
                BetaItemReferenceParamType2.ItemReference => "item_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaItemReferenceParamType2? ToEnum(string value)
        {
            return value switch
            {
                "item_reference" => BetaItemReferenceParamType2.ItemReference,
                _ => null,
            };
        }
    }
}