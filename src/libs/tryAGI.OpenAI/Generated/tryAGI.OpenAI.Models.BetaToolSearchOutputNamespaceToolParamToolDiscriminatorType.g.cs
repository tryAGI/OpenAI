
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType
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
    public static class BetaToolSearchOutputNamespaceToolParamToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType value)
        {
            return value switch
            {
                BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType.Custom => "custom",
                BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType.Custom,
                "function" => BetaToolSearchOutputNamespaceToolParamToolDiscriminatorType.Function,
                _ => null,
            };
        }
    }
}