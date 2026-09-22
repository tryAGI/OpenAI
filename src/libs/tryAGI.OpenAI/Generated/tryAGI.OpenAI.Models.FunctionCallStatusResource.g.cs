
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of a tool call.
    /// </summary>
    public enum FunctionCallStatusResource
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
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
    public static class FunctionCallStatusResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallStatusResource value)
        {
            return value switch
            {
                FunctionCallStatusResource.Completed => "completed",
                FunctionCallStatusResource.Failed => "failed",
                FunctionCallStatusResource.InProgress => "in_progress",
                FunctionCallStatusResource.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallStatusResource? ToEnum(string value)
        {
            return value switch
            {
                "completed" => FunctionCallStatusResource.Completed,
                "failed" => FunctionCallStatusResource.Failed,
                "in_progress" => FunctionCallStatusResource.InProgress,
                "incomplete" => FunctionCallStatusResource.Incomplete,
                _ => null,
            };
        }
    }
}