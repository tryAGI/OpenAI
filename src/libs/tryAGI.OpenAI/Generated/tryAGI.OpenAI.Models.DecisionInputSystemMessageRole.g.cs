
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: system
    /// </summary>
    public enum DecisionInputSystemMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputSystemMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputSystemMessageRole value)
        {
            return value switch
            {
                DecisionInputSystemMessageRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputSystemMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => DecisionInputSystemMessageRole.System,
                _ => null,
            };
        }
    }
}