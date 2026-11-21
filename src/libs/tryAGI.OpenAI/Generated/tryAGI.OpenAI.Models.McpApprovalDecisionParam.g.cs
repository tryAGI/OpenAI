
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum McpApprovalDecisionParam
    {
        /// <summary>
        ///
        /// </summary>
        Approve,
        /// <summary>
        ///
        /// </summary>
        Cancel,
        /// <summary>
        ///
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpApprovalDecisionParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpApprovalDecisionParam value)
        {
            return value switch
            {
                McpApprovalDecisionParam.Approve => "approve",
                McpApprovalDecisionParam.Cancel => "cancel",
                McpApprovalDecisionParam.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpApprovalDecisionParam? ToEnum(string value)
        {
            return value switch
            {
                "approve" => McpApprovalDecisionParam.Approve,
                "cancel" => McpApprovalDecisionParam.Cancel,
                "deny" => McpApprovalDecisionParam.Deny,
                _ => null,
            };
        }
    }
}