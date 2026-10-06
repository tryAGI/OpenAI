
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the tool. Always `namespace`.<br/>
    /// Default Value: namespace
    /// </summary>
    public enum BetaToolSearchOutputNamespaceToolParamType
    {
        /// <summary>
        ///
        /// </summary>
        Namespace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolSearchOutputNamespaceToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolSearchOutputNamespaceToolParamType value)
        {
            return value switch
            {
                BetaToolSearchOutputNamespaceToolParamType.Namespace => "namespace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolSearchOutputNamespaceToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "namespace" => BetaToolSearchOutputNamespaceToolParamType.Namespace,
                _ => null,
            };
        }
    }
}