
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: system
    /// </summary>
    public enum LiveDecisionSystemMessageParamRole
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionSystemMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionSystemMessageParamRole value)
        {
            return value switch
            {
                LiveDecisionSystemMessageParamRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionSystemMessageParamRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => LiveDecisionSystemMessageParamRole.System,
                _ => null,
            };
        }
    }
}