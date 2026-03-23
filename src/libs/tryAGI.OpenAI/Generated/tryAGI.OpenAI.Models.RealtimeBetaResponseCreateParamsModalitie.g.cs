
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeBetaResponseCreateParamsModalitie
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
    public static class RealtimeBetaResponseCreateParamsModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaResponseCreateParamsModalitie value)
        {
            return value switch
            {
                RealtimeBetaResponseCreateParamsModalitie.Audio => "audio",
                RealtimeBetaResponseCreateParamsModalitie.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaResponseCreateParamsModalitie? ToEnum(string value)
        {
            return value switch
            {
                "audio" => RealtimeBetaResponseCreateParamsModalitie.Audio,
                "text" => RealtimeBetaResponseCreateParamsModalitie.Text,
                _ => null,
            };
        }
    }
}