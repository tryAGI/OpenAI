
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: developer
    /// </summary>
    public enum DecisionInputDeveloperMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputDeveloperMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputDeveloperMessageRole value)
        {
            return value switch
            {
                DecisionInputDeveloperMessageRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputDeveloperMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => DecisionInputDeveloperMessageRole.Developer,
                _ => null,
            };
        }
    }
}