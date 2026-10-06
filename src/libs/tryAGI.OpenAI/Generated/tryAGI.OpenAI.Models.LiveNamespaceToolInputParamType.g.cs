
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: namespace
    /// </summary>
    public enum LiveNamespaceToolInputParamType
    {
        /// <summary>
        ///
        /// </summary>
        Namespace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveNamespaceToolInputParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveNamespaceToolInputParamType value)
        {
            return value switch
            {
                LiveNamespaceToolInputParamType.Namespace => "namespace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveNamespaceToolInputParamType? ToEnum(string value)
        {
            return value switch
            {
                "namespace" => LiveNamespaceToolInputParamType.Namespace,
                _ => null,
            };
        }
    }
}