
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always 'response.mcp_list_tools.failed'.
    /// </summary>
    public enum BetaResponseMCPListToolsFailedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseMcpListToolsFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseMCPListToolsFailedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseMCPListToolsFailedEventType value)
        {
            return value switch
            {
                BetaResponseMCPListToolsFailedEventType.ResponseMcpListToolsFailed => "response.mcp_list_tools.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseMCPListToolsFailedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_list_tools.failed" => BetaResponseMCPListToolsFailedEventType.ResponseMcpListToolsFailed,
                _ => null,
            };
        }
    }
}