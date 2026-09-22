
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `function_call_output`.<br/>
    /// Default Value: function_call_output
    /// </summary>
    public enum FunctionCallOutputItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionCallOutputItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallOutputItemResourceType value)
        {
            return value switch
            {
                FunctionCallOutputItemResourceType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallOutputItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => FunctionCallOutputItemResourceType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}