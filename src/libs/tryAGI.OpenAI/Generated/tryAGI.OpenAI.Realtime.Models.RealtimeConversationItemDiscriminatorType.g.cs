
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeConversationItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        FunctionCallOutput,
        /// <summary>
        /// 
        /// </summary>
        McpApprovalRequest,
        /// <summary>
        /// 
        /// </summary>
        McpApprovalResponse,
        /// <summary>
        /// 
        /// </summary>
        McpCall,
        /// <summary>
        /// 
        /// </summary>
        McpListTools,
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemDiscriminatorType value)
        {
            return value switch
            {
                RealtimeConversationItemDiscriminatorType.FunctionCall => "function_call",
                RealtimeConversationItemDiscriminatorType.FunctionCallOutput => "function_call_output",
                RealtimeConversationItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                RealtimeConversationItemDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                RealtimeConversationItemDiscriminatorType.McpCall => "mcp_call",
                RealtimeConversationItemDiscriminatorType.McpListTools => "mcp_list_tools",
                RealtimeConversationItemDiscriminatorType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => RealtimeConversationItemDiscriminatorType.FunctionCall,
                "function_call_output" => RealtimeConversationItemDiscriminatorType.FunctionCallOutput,
                "mcp_approval_request" => RealtimeConversationItemDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => RealtimeConversationItemDiscriminatorType.McpApprovalResponse,
                "mcp_call" => RealtimeConversationItemDiscriminatorType.McpCall,
                "mcp_list_tools" => RealtimeConversationItemDiscriminatorType.McpListTools,
                "message" => RealtimeConversationItemDiscriminatorType.Message,
                _ => null,
            };
        }
    }
}