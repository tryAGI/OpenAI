
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always 'response.mcp_list_tools.in_progress'.
    /// </summary>
    public enum BetaResponseMCPListToolsInProgressEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpListToolsInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseMCPListToolsInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseMCPListToolsInProgressEventType value)
        {
            return value switch
            {
                BetaResponseMCPListToolsInProgressEventType.ResponseMcpListToolsInProgress => "response.mcp_list_tools.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseMCPListToolsInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_list_tools.in_progress" => BetaResponseMCPListToolsInProgressEventType.ResponseMcpListToolsInProgress,
                _ => null,
            };
        }
    }
}