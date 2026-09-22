
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum LiveDataChannelConfigParamAllowedServerEvents
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDataChannelConfigParamAllowedServerEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDataChannelConfigParamAllowedServerEvents value)
        {
            return value switch
            {
                LiveDataChannelConfigParamAllowedServerEvents.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDataChannelConfigParamAllowedServerEvents? ToEnum(string value)
        {
            return value switch
            {
                "all" => LiveDataChannelConfigParamAllowedServerEvents.All,
                _ => null,
            };
        }
    }
}