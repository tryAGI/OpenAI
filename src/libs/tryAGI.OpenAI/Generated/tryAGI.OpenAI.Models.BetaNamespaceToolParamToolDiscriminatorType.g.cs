
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaNamespaceToolParamToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaNamespaceToolParamToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaNamespaceToolParamToolDiscriminatorType value)
        {
            return value switch
            {
                BetaNamespaceToolParamToolDiscriminatorType.Custom => "custom",
                BetaNamespaceToolParamToolDiscriminatorType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaNamespaceToolParamToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => BetaNamespaceToolParamToolDiscriminatorType.Custom,
                "function" => BetaNamespaceToolParamToolDiscriminatorType.Function,
                _ => null,
            };
        }
    }
}