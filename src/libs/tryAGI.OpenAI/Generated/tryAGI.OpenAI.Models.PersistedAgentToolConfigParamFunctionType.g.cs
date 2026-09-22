
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `function`.<br/>
    /// Default Value: function
    /// </summary>
    public enum PersistedAgentToolConfigParamFunctionType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersistedAgentToolConfigParamFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedAgentToolConfigParamFunctionType value)
        {
            return value switch
            {
                PersistedAgentToolConfigParamFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedAgentToolConfigParamFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => PersistedAgentToolConfigParamFunctionType.Function,
                _ => null,
            };
        }
    }
}