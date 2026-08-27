
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Whether the API key's owner currently has effective access to the project.
    /// </summary>
    public enum ProjectApiKeyOwnerProjectAccess
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectApiKeyOwnerProjectAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectApiKeyOwnerProjectAccess value)
        {
            return value switch
            {
                ProjectApiKeyOwnerProjectAccess.Active => "active",
                ProjectApiKeyOwnerProjectAccess.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectApiKeyOwnerProjectAccess? ToEnum(string value)
        {
            return value switch
            {
                "active" => ProjectApiKeyOwnerProjectAccess.Active,
                "inactive" => ProjectApiKeyOwnerProjectAccess.Inactive,
                _ => null,
            };
        }
    }
}