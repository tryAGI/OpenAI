
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseSteerRequiredInputRequiredToolSearchOutputExecution
    {
        /// <summary>
        ///
        /// </summary>
        Client,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSteerRequiredInputRequiredToolSearchOutputExecutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSteerRequiredInputRequiredToolSearchOutputExecution value)
        {
            return value switch
            {
                ResponseSteerRequiredInputRequiredToolSearchOutputExecution.Client => "client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSteerRequiredInputRequiredToolSearchOutputExecution? ToEnum(string value)
        {
            return value switch
            {
                "client" => ResponseSteerRequiredInputRequiredToolSearchOutputExecution.Client,
                _ => null,
            };
        }
    }
}