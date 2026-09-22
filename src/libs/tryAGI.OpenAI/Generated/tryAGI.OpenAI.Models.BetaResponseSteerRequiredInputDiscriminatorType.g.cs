
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseSteerRequiredInputDiscriminatorType
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
    public static class BetaResponseSteerRequiredInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerRequiredInputDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseSteerRequiredInputDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                BetaResponseSteerRequiredInputDiscriminatorType.ComputerCallOutput => "computer_call_output",
                BetaResponseSteerRequiredInputDiscriminatorType.CustomToolCallOutput => "custom_tool_call_output",
                BetaResponseSteerRequiredInputDiscriminatorType.FunctionCallOutput => "function_call_output",
                BetaResponseSteerRequiredInputDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                BetaResponseSteerRequiredInputDiscriminatorType.ShellCallOutput => "shell_call_output",
                BetaResponseSteerRequiredInputDiscriminatorType.ToolSearchOutput => "tool_search_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerRequiredInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call_output" => BetaResponseSteerRequiredInputDiscriminatorType.ApplyPatchCallOutput,
                "computer_call_output" => BetaResponseSteerRequiredInputDiscriminatorType.ComputerCallOutput,
                "custom_tool_call_output" => BetaResponseSteerRequiredInputDiscriminatorType.CustomToolCallOutput,
                "function_call_output" => BetaResponseSteerRequiredInputDiscriminatorType.FunctionCallOutput,
                "mcp_approval_response" => BetaResponseSteerRequiredInputDiscriminatorType.McpApprovalResponse,
                "shell_call_output" => BetaResponseSteerRequiredInputDiscriminatorType.ShellCallOutput,
                "tool_search_output" => BetaResponseSteerRequiredInputDiscriminatorType.ToolSearchOutput,
                _ => null,
            };
        }
    }
}