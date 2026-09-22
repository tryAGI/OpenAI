
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `function_call`.<br/>
    /// Default Value: function_call
    /// </summary>
    public enum SessionRequiredActionResourceFunctionCallType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionRequiredActionResourceFunctionCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionRequiredActionResourceFunctionCallType value)
        {
            return value switch
            {
                SessionRequiredActionResourceFunctionCallType.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionRequiredActionResourceFunctionCallType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => SessionRequiredActionResourceFunctionCallType.FunctionCall,
                _ => null,
            };
        }
    }
}