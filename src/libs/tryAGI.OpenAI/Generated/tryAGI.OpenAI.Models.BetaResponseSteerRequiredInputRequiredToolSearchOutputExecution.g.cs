
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution
    {
        /// <summary>
        ///
        /// </summary>
        Client,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseSteerRequiredInputRequiredToolSearchOutputExecutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution value)
        {
            return value switch
            {
                BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution.Client => "client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution? ToEnum(string value)
        {
            return value switch
            {
                "client" => BetaResponseSteerRequiredInputRequiredToolSearchOutputExecution.Client,
                _ => null,
            };
        }
    }
}