
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Logs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType.Image => "image",
                BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType.Image,
                "logs" => BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType.Logs,
                _ => null,
            };
        }
    }
}