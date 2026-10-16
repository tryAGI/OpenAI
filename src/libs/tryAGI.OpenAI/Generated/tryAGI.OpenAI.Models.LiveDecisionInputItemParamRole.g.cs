
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The message role. Always `user`.<br/>
    /// Default Value: user
    /// </summary>
    public enum LiveDecisionInputItemParamRole
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionInputItemParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionInputItemParamRole value)
        {
            return value switch
            {
                LiveDecisionInputItemParamRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionInputItemParamRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => LiveDecisionInputItemParamRole.User,
                _ => null,
            };
        }
    }
}