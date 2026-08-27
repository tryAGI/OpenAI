
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always 'response.mcp_list_tools.completed'.
    /// </summary>
    public enum BetaResponseMCPListToolsCompletedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseMcpListToolsCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseMCPListToolsCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseMCPListToolsCompletedEventType value)
        {
            return value switch
            {
                BetaResponseMCPListToolsCompletedEventType.ResponseMcpListToolsCompleted => "response.mcp_list_tools.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseMCPListToolsCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_list_tools.completed" => BetaResponseMCPListToolsCompletedEventType.ResponseMcpListToolsCompleted,
                _ => null,
            };
        }
    }
}