
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseSteerRequiredInputDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ApplyPatchCallOutput,
        /// <summary>
        ///
        /// </summary>
        ComputerCallOutput,
        /// <summary>
        ///
        /// </summary>
        CustomToolCallOutput,
        /// <summary>
        ///
        /// </summary>
        FunctionCallOutput,
        /// <summary>
        ///
        /// </summary>
        McpApprovalResponse,
        /// <summary>
        ///
        /// </summary>
        ShellCallOutput,
        /// <summary>
        ///
        /// </summary>
        ToolSearchOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSteerRequiredInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSteerRequiredInputDiscriminatorType value)
        {
            return value switch
            {
                ResponseSteerRequiredInputDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                ResponseSteerRequiredInputDiscriminatorType.ComputerCallOutput => "computer_call_output",
                ResponseSteerRequiredInputDiscriminatorType.CustomToolCallOutput => "custom_tool_call_output",
                ResponseSteerRequiredInputDiscriminatorType.FunctionCallOutput => "function_call_output",
                ResponseSteerRequiredInputDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                ResponseSteerRequiredInputDiscriminatorType.ShellCallOutput => "shell_call_output",
                ResponseSteerRequiredInputDiscriminatorType.ToolSearchOutput => "tool_search_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSteerRequiredInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call_output" => ResponseSteerRequiredInputDiscriminatorType.ApplyPatchCallOutput,
                "computer_call_output" => ResponseSteerRequiredInputDiscriminatorType.ComputerCallOutput,
                "custom_tool_call_output" => ResponseSteerRequiredInputDiscriminatorType.CustomToolCallOutput,
                "function_call_output" => ResponseSteerRequiredInputDiscriminatorType.FunctionCallOutput,
                "mcp_approval_response" => ResponseSteerRequiredInputDiscriminatorType.McpApprovalResponse,
                "shell_call_output" => ResponseSteerRequiredInputDiscriminatorType.ShellCallOutput,
                "tool_search_output" => ResponseSteerRequiredInputDiscriminatorType.ToolSearchOutput,
                _ => null,
            };
        }
    }
}