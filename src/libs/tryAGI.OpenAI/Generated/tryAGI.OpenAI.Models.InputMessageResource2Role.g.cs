
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The role of the message author. Always `user`.<br/>
    /// Default Value: user
    /// </summary>
    public enum InputMessageResource2Role
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputMessageResource2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageResource2Role value)
        {
            return value switch
            {
                InputMessageResource2Role.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageResource2Role? ToEnum(string value)
        {
            return value switch
            {
                "user" => InputMessageResource2Role.User,
                _ => null,
            };
        }
    }
}