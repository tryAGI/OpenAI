
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Whether a vault or credential is active or archived.
    /// </summary>
    public enum VaultStatusParam
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VaultStatusParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VaultStatusParam value)
        {
            return value switch
            {
                VaultStatusParam.Active => "active",
                VaultStatusParam.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VaultStatusParam? ToEnum(string value)
        {
            return value switch
            {
                "active" => VaultStatusParam.Active,
                "archived" => VaultStatusParam.Archived,
                _ => null,
            };
        }
    }
}