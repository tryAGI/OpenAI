
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `function`.<br/>
    /// Default Value: function
    /// </summary>
    public enum AgentToolConfigParamFunctionType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentToolConfigParamFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolConfigParamFunctionType value)
        {
            return value switch
            {
                AgentToolConfigParamFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolConfigParamFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => AgentToolConfigParamFunctionType.Function,
                _ => null,
            };
        }
    }
}