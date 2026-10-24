
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: developer
    /// </summary>
    public enum LiveDecisionDeveloperMessageParamRole
    {
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionDeveloperMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionDeveloperMessageParamRole value)
        {
            return value switch
            {
                LiveDecisionDeveloperMessageParamRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionDeveloperMessageParamRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => LiveDecisionDeveloperMessageParamRole.Developer,
                _ => null,
            };
        }
    }
}