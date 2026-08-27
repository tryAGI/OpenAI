
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaToolSearchExecutionType
    {
        /// <summary>
        ///
        /// </summary>
        Client,
        /// <summary>
        ///
        /// </summary>
        Server,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolSearchExecutionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolSearchExecutionType value)
        {
            return value switch
            {
                BetaToolSearchExecutionType.Client => "client",
                BetaToolSearchExecutionType.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolSearchExecutionType? ToEnum(string value)
        {
            return value switch
            {
                "client" => BetaToolSearchExecutionType.Client,
                "server" => BetaToolSearchExecutionType.Server,
                _ => null,
            };
        }
    }
}