
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The role of the message author. Always `user`.<br/>
    /// Default Value: user
    /// </summary>
    public enum InputMessageParamRole
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageParamRole value)
        {
            return value switch
            {
                InputMessageParamRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageParamRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => InputMessageParamRole.User,
                _ => null,
            };
        }
    }
}