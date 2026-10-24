
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: developer
    /// </summary>
    public enum LiveDecisionStoredDeveloperMessageParamRole
    {
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionStoredDeveloperMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredDeveloperMessageParamRole value)
        {
            return value switch
            {
                LiveDecisionStoredDeveloperMessageParamRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredDeveloperMessageParamRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => LiveDecisionStoredDeveloperMessageParamRole.Developer,
                _ => null,
            };
        }
    }
}