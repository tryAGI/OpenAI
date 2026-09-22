
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The network access mode for an OpenAI-hosted environment.
    /// </summary>
    public enum NetworkAccessResource
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
        /// <summary>
        ///
        /// </summary>
        Restricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NetworkAccessResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkAccessResource value)
        {
            return value switch
            {
                NetworkAccessResource.Disabled => "disabled",
                NetworkAccessResource.Enabled => "enabled",
                NetworkAccessResource.Restricted => "restricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkAccessResource? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => NetworkAccessResource.Disabled,
                "enabled" => NetworkAccessResource.Enabled,
                "restricted" => NetworkAccessResource.Restricted,
                _ => null,
            };
        }
    }
}