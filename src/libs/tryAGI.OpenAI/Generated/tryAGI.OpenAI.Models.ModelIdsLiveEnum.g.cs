
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelIdsLiveEnum
    {
        /// <summary>
        ///
        /// </summary>
        GptLive1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelIdsLiveEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelIdsLiveEnum value)
        {
            return value switch
            {
                ModelIdsLiveEnum.GptLive1 => "gpt-live-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelIdsLiveEnum? ToEnum(string value)
        {
            return value switch
            {
                "gpt-live-1" => ModelIdsLiveEnum.GptLive1,
                _ => null,
            };
        }
    }
}