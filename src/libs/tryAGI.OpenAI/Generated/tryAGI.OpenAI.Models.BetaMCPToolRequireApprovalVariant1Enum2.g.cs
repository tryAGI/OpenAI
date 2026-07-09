
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specify a single approval policy for all tools. One of `always` or<br/>
    /// `never`. When set to `always`, all tools will require approval. When<br/>
    /// set to `never`, all tools will not require approval.
    /// </summary>
    public enum BetaMCPToolRequireApprovalVariant1Enum2
    {
        /// <summary>
        /// 
        /// </summary>
        Always,
        /// <summary>
        /// 
        /// </summary>
        Never,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMCPToolRequireApprovalVariant1Enum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMCPToolRequireApprovalVariant1Enum2 value)
        {
            return value switch
            {
                BetaMCPToolRequireApprovalVariant1Enum2.Always => "always",
                BetaMCPToolRequireApprovalVariant1Enum2.Never => "never",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMCPToolRequireApprovalVariant1Enum2? ToEnum(string value)
        {
            return value switch
            {
                "always" => BetaMCPToolRequireApprovalVariant1Enum2.Always,
                "never" => BetaMCPToolRequireApprovalVariant1Enum2.Never,
                _ => null,
            };
        }
    }
}