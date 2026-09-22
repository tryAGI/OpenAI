
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `function`.<br/>
    /// Default Value: function
    /// </summary>
    public enum AgentToolResourceFunctionType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentToolResourceFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolResourceFunctionType value)
        {
            return value switch
            {
                AgentToolResourceFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolResourceFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => AgentToolResourceFunctionType.Function,
                _ => null,
            };
        }
    }
}