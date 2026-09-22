
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The author of this history message. Always `developer`.<br/>
    /// Default Value: developer
    /// </summary>
    public enum LiveInitialDeveloperMessageItemParamRole
    {
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInitialDeveloperMessageItemParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInitialDeveloperMessageItemParamRole value)
        {
            return value switch
            {
                LiveInitialDeveloperMessageItemParamRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInitialDeveloperMessageItemParamRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => LiveInitialDeveloperMessageItemParamRole.Developer,
                _ => null,
            };
        }
    }
}