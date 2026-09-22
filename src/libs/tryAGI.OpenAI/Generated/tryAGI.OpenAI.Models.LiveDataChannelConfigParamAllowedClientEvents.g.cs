
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum LiveDataChannelConfigParamAllowedClientEvents
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDataChannelConfigParamAllowedClientEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDataChannelConfigParamAllowedClientEvents value)
        {
            return value switch
            {
                LiveDataChannelConfigParamAllowedClientEvents.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDataChannelConfigParamAllowedClientEvents? ToEnum(string value)
        {
            return value switch
            {
                "all" => LiveDataChannelConfigParamAllowedClientEvents.All,
                _ => null,
            };
        }
    }
}