
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: system
    /// </summary>
    public enum LiveDecisionStoredSystemMessageParamRole
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionStoredSystemMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredSystemMessageParamRole value)
        {
            return value switch
            {
                LiveDecisionStoredSystemMessageParamRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredSystemMessageParamRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => LiveDecisionStoredSystemMessageParamRole.System,
                _ => null,
            };
        }
    }
}