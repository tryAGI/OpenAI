
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AdditionalTools,
        /// <summary>
        /// 
        /// </summary>
        ApplyPatchCall,
        /// <summary>
        /// 
        /// </summary>
        ApplyPatchCallOutput,
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreterCall,
        /// <summary>
        /// 
        /// </summary>
        Compaction,
        /// <summary>
        /// 
        /// </summary>
        ComputerCall,
        /// <summary>
        /// 
        /// </summary>
        ComputerCallOutput,
        /// <summary>
        /// 
        /// </summary>
        CustomToolCall,
        /// <summary>
        /// 
        /// </summary>
        CustomToolCallOutput,
        /// <summary>
        /// 
        /// </summary>
        FileSearchCall,
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
        ImageGenerationCall,
        /// <summary>
        /// 
        /// </summary>
        LocalShellCall,
        /// <summary>
        /// 
        /// </summary>
        LocalShellCallOutput,
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
        /// <summary>
        /// 
        /// </summary>
        Reasoning,
        /// <summary>
        /// 
        /// </summary>
        ShellCall,
        /// <summary>
        /// 
        /// </summary>
        ShellCallOutput,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchCall,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchOutput,
        /// <summary>
        /// 
        /// </summary>
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ItemDiscriminatorType value)
        {
            return value switch
            {
                ItemDiscriminatorType.AdditionalTools => "additional_tools",
                ItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                ItemDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                ItemDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                ItemDiscriminatorType.Compaction => "compaction",
                ItemDiscriminatorType.ComputerCall => "computer_call",
                ItemDiscriminatorType.ComputerCallOutput => "computer_call_output",
                ItemDiscriminatorType.CustomToolCall => "custom_tool_call",
                ItemDiscriminatorType.CustomToolCallOutput => "custom_tool_call_output",
                ItemDiscriminatorType.FileSearchCall => "file_search_call",
                ItemDiscriminatorType.FunctionCall => "function_call",
                ItemDiscriminatorType.FunctionCallOutput => "function_call_output",
                ItemDiscriminatorType.ImageGenerationCall => "image_generation_call",
                ItemDiscriminatorType.LocalShellCall => "local_shell_call",
                ItemDiscriminatorType.LocalShellCallOutput => "local_shell_call_output",
                ItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                ItemDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                ItemDiscriminatorType.McpCall => "mcp_call",
                ItemDiscriminatorType.McpListTools => "mcp_list_tools",
                ItemDiscriminatorType.Message => "message",
                ItemDiscriminatorType.Reasoning => "reasoning",
                ItemDiscriminatorType.ShellCall => "shell_call",
                ItemDiscriminatorType.ShellCallOutput => "shell_call_output",
                ItemDiscriminatorType.ToolSearchCall => "tool_search_call",
                ItemDiscriminatorType.ToolSearchOutput => "tool_search_output",
                ItemDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "additional_tools" => ItemDiscriminatorType.AdditionalTools,
                "apply_patch_call" => ItemDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => ItemDiscriminatorType.ApplyPatchCallOutput,
                "code_interpreter_call" => ItemDiscriminatorType.CodeInterpreterCall,
                "compaction" => ItemDiscriminatorType.Compaction,
                "computer_call" => ItemDiscriminatorType.ComputerCall,
                "computer_call_output" => ItemDiscriminatorType.ComputerCallOutput,
                "custom_tool_call" => ItemDiscriminatorType.CustomToolCall,
                "custom_tool_call_output" => ItemDiscriminatorType.CustomToolCallOutput,
                "file_search_call" => ItemDiscriminatorType.FileSearchCall,
                "function_call" => ItemDiscriminatorType.FunctionCall,
                "function_call_output" => ItemDiscriminatorType.FunctionCallOutput,
                "image_generation_call" => ItemDiscriminatorType.ImageGenerationCall,
                "local_shell_call" => ItemDiscriminatorType.LocalShellCall,
                "local_shell_call_output" => ItemDiscriminatorType.LocalShellCallOutput,
                "mcp_approval_request" => ItemDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => ItemDiscriminatorType.McpApprovalResponse,
                "mcp_call" => ItemDiscriminatorType.McpCall,
                "mcp_list_tools" => ItemDiscriminatorType.McpListTools,
                "message" => ItemDiscriminatorType.Message,
                "reasoning" => ItemDiscriminatorType.Reasoning,
                "shell_call" => ItemDiscriminatorType.ShellCall,
                "shell_call_output" => ItemDiscriminatorType.ShellCallOutput,
                "tool_search_call" => ItemDiscriminatorType.ToolSearchCall,
                "tool_search_output" => ItemDiscriminatorType.ToolSearchOutput,
                "web_search_call" => ItemDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}