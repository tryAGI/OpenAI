
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeBetaResponseModalitie
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaResponseModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaResponseModalitie value)
        {
            return value switch
            {
                RealtimeBetaResponseModalitie.Audio => "audio",
                RealtimeBetaResponseModalitie.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaResponseModalitie? ToEnum(string value)
        {
            return value switch
            {
                "audio" => RealtimeBetaResponseModalitie.Audio,
                "text" => RealtimeBetaResponseModalitie.Text,
                _ => null,
            };
        }
    }
}