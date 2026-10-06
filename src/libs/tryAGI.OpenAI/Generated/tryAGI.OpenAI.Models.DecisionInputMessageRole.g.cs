
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: user
    /// </summary>
    public enum DecisionInputMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputMessageRole value)
        {
            return value switch
            {
                DecisionInputMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => DecisionInputMessageRole.User,
                _ => null,
            };
        }
    }
}