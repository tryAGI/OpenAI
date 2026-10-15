
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionCallStatusParam
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionCallStatusParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallStatusParam value)
        {
            return value switch
            {
                FunctionCallStatusParam.Completed => "completed",
                FunctionCallStatusParam.InProgress => "in_progress",
                FunctionCallStatusParam.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallStatusParam? ToEnum(string value)
        {
            return value switch
            {
                "completed" => FunctionCallStatusParam.Completed,
                "in_progress" => FunctionCallStatusParam.InProgress,
                "incomplete" => FunctionCallStatusParam.Incomplete,
                _ => null,
            };
        }
    }
}