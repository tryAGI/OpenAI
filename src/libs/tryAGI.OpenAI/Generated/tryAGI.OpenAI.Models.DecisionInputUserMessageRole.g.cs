
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: user
    /// </summary>
    public enum DecisionInputUserMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputUserMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputUserMessageRole value)
        {
            return value switch
            {
                DecisionInputUserMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputUserMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => DecisionInputUserMessageRole.User,
                _ => null,
            };
        }
    }
}