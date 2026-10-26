
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionInputMessageDiscriminatorRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        Developer,
        /// <summary>
        ///
        /// </summary>
        System,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputMessageDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputMessageDiscriminatorRole value)
        {
            return value switch
            {
                DecisionInputMessageDiscriminatorRole.Assistant => "assistant",
                DecisionInputMessageDiscriminatorRole.Developer => "developer",
                DecisionInputMessageDiscriminatorRole.System => "system",
                DecisionInputMessageDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputMessageDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => DecisionInputMessageDiscriminatorRole.Assistant,
                "developer" => DecisionInputMessageDiscriminatorRole.Developer,
                "system" => DecisionInputMessageDiscriminatorRole.System,
                "user" => DecisionInputMessageDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}