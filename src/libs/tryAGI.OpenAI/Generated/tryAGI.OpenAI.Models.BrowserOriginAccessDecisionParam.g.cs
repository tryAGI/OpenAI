
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The user's decision for a browser origin access request.
    /// </summary>
    public enum BrowserOriginAccessDecisionParam
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
    public static class BrowserOriginAccessDecisionParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BrowserOriginAccessDecisionParam value)
        {
            return value switch
            {
                BrowserOriginAccessDecisionParam.Approve => "approve",
                BrowserOriginAccessDecisionParam.Cancel => "cancel",
                BrowserOriginAccessDecisionParam.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BrowserOriginAccessDecisionParam? ToEnum(string value)
        {
            return value switch
            {
                "approve" => BrowserOriginAccessDecisionParam.Approve,
                "cancel" => BrowserOriginAccessDecisionParam.Cancel,
                "deny" => BrowserOriginAccessDecisionParam.Deny,
                _ => null,
            };
        }
    }
}