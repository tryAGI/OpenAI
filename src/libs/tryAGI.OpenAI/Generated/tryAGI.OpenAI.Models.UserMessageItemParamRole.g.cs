
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The message role. Always `user`.<br/>
    /// Default Value: user
    /// </summary>
    public enum UserMessageItemParamRole
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserMessageItemParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserMessageItemParamRole value)
        {
            return value switch
            {
                UserMessageItemParamRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserMessageItemParamRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => UserMessageItemParamRole.User,
                _ => null,
            };
        }
    }
}