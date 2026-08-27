
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the output. Always `logs`.<br/>
    /// Default Value: logs
    /// </summary>
    public enum BetaCodeInterpreterOutputLogsType
    {
        /// <summary>
        ///
        /// </summary>
        Logs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCodeInterpreterOutputLogsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCodeInterpreterOutputLogsType value)
        {
            return value switch
            {
                BetaCodeInterpreterOutputLogsType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCodeInterpreterOutputLogsType? ToEnum(string value)
        {
            return value switch
            {
                "logs" => BetaCodeInterpreterOutputLogsType.Logs,
                _ => null,
            };
        }
    }
}