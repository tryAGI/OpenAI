
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The message role. Always `user`.<br/>
    /// Default Value: user
    /// </summary>
    public enum LiveDecisionStoredUserMessageParamRole
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionStoredUserMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredUserMessageParamRole value)
        {
            return value switch
            {
                LiveDecisionStoredUserMessageParamRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredUserMessageParamRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => LiveDecisionStoredUserMessageParamRole.User,
                _ => null,
            };
        }
    }
}