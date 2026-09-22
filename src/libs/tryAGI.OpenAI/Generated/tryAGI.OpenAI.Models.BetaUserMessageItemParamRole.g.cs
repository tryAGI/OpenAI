
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The message role. Always `user`.<br/>
    /// Default Value: user
    /// </summary>
    public enum BetaUserMessageItemParamRole
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUserMessageItemParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUserMessageItemParamRole value)
        {
            return value switch
            {
                BetaUserMessageItemParamRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUserMessageItemParamRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => BetaUserMessageItemParamRole.User,
                _ => null,
            };
        }
    }
}