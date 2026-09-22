
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The author of this history message. Always `user`.<br/>
    /// Default Value: user
    /// </summary>
    public enum LiveInitialUserMessageItemParamRole
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInitialUserMessageItemParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInitialUserMessageItemParamRole value)
        {
            return value switch
            {
                LiveInitialUserMessageItemParamRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInitialUserMessageItemParamRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => LiveInitialUserMessageItemParamRole.User,
                _ => null,
            };
        }
    }
}