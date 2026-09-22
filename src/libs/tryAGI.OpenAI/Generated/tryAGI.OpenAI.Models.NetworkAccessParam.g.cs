
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The network access mode for an OpenAI-hosted environment.
    /// </summary>
    public enum NetworkAccessParam
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
    public static class NetworkAccessParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkAccessParam value)
        {
            return value switch
            {
                NetworkAccessParam.Disabled => "disabled",
                NetworkAccessParam.Enabled => "enabled",
                NetworkAccessParam.Restricted => "restricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkAccessParam? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => NetworkAccessParam.Disabled,
                "enabled" => NetworkAccessParam.Enabled,
                "restricted" => NetworkAccessParam.Restricted,
                _ => null,
            };
        }
    }
}