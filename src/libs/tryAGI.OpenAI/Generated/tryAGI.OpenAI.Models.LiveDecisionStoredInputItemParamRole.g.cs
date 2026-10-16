
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The message role. Always `user`.<br/>
    /// Default Value: user
    /// </summary>
    public enum LiveDecisionStoredInputItemParamRole
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionStoredInputItemParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredInputItemParamRole value)
        {
            return value switch
            {
                LiveDecisionStoredInputItemParamRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredInputItemParamRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => LiveDecisionStoredInputItemParamRole.User,
                _ => null,
            };
        }
    }
}