
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the tool. Always `namespace`.<br/>
    /// Default Value: namespace
    /// </summary>
    public enum NamespaceToolParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Namespace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NamespaceToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NamespaceToolParamType value)
        {
            return value switch
            {
                NamespaceToolParamType.Namespace => "namespace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NamespaceToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "namespace" => NamespaceToolParamType.Namespace,
                _ => null,
            };
        }
    }
}